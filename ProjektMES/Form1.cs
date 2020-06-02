using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektMES
{
    public partial class Form1 : Form
    {
        GlobalData globalData;
        Grid grid;
        double[,] c;
        double[,] h;
        double[] p;
        public Form1()
        {
            InitializeComponent();
        }

        private void buildMeshButton_Click(object sender, EventArgs e)
        {
            double initTemp = double.Parse(initTempBox.Text.Replace('.', ','));
            double symTime = double.Parse(symTimeBox.Text.Replace('.', ','));
            double symStepTime = double.Parse(symStepTimeBox.Text.Replace('.', ','));
            double ambientTemp = double.Parse(ambientTempBox.Text.Replace('.', ','));
            double alpha = double.Parse(alphaBox.Text.Replace('.', ','));
            double H = double.Parse(hBox.Text.Replace('.', ','));
            double B = double.Parse(bBox.Text.Replace('.', ','));
            int nH = int.Parse(nHBox.Text);
            int nB = int.Parse(nBBox.Text);
            double specHeat = double.Parse(specHeatBox.Text.Replace('.', ','));
            double conductivity = double.Parse(conductivityBox.Text.Replace('.', ','));
            double density = double.Parse(densityBox.Text.Replace('.', ','));

            this.globalData = new GlobalData(initTemp, symTime, symStepTime, ambientTemp, alpha, H, B, nH, nB, specHeat, conductivity, density);
            grid = new Grid(globalData);
            UniversalElement[] universalElements = UniversalElement.CreateUniversalElements();
            int nodeNumber = globalData.GetNumberOfNodes();
            c = new double[nodeNumber,nodeNumber];
            h = new double[nodeNumber,nodeNumber];
            p = new double[nodeNumber];
            

            foreach (Element element in grid.GetElements())
            {
                int elementNodeNumber = element.GetNodes().Length;
                double[,] elementH = new double[elementNodeNumber,elementNodeNumber];
                double[,] elementC = new double[elementNodeNumber,elementNodeNumber];
                double[] elementP;
                foreach (UniversalElement universalElement in universalElements)
                {
                    Jacobian jacobian = new Jacobian(element, universalElement);
                    elementH = MatrixOperations.addition(elementH, element.GetPointMatrixH(jacobian, globalData.GetConductivity()));
                    elementC = MatrixOperations.addition(elementC, element.GetPointMatrixC(universalElement, jacobian.GetDetJ(), globalData.GetSpecificHeat(), globalData.GetDensity()));                   
                }             
                elementH = MatrixOperations.addition(elementH, element.GetMatrixHbc(globalData.GetAlfa()));
                elementP = element.getVectorP(globalData.GetAlfa(), globalData.GetAmbientTemp());
                Node[] nodes = element.GetNodes();
                for (int i = 0; i < nodes.Length; i++)
                {
                    for (int j = 0; j < nodes.Length; j++)
                    {
                        c[nodes[i].GetId() - 1,nodes[j].GetId() - 1] += elementC[i,j];
                        h[nodes[i].GetId() - 1,nodes[j].GetId() - 1] += elementH[i,j];
                    }
                    p[nodes[i].GetId() - 1] += elementP[i];
                }

            }
           
        }

        private void showAllNodesButton_Click(object sender, EventArgs e)
        {
            results.Text = "";
            for (int i = 1; i <= grid.GetNodes().Length; i++) {
                Node node = grid.GetNodes(i);
                results.Text += "Node id: " + node.id + " Node x: " + node.x + "  Node y: " + node.y + " , \n T: " + node.t + " Node BC: " + node.BC + "\n\n";
            }

        }

        private void simulateButton_Click_1(object sender, EventArgs e)
        {
            results.Text = "";
            double[,] resultH;
            double[] resultP;
            for (int time = 0; time < globalData.GetSymTime(); time += (int)globalData.GetStepTime())
            {
                double[] t0 = grid.GetTemperatures();
                resultP = MatrixOperations.addition(p, MatrixOperations.multiply(c, t0, 1 / globalData.GetStepTime()));
                resultH = MatrixOperations.addition(h, MatrixOperations.multiply(c, new double[] { 1 / globalData.GetStepTime() }));
                t0 = MatrixOperations.gaussianElimination(resultH, resultP);
                grid.SetTemperatures(t0);               
                results.Text+= "Time[s]: " + (time + globalData.GetStepTime())+ "\t\tMinTemperature [°C]: " + min(t0)+ "\t\tMaxTemperature [°C]: " + max(t0)+ "\n";
                Console.WriteLine("Time[s]: " + (time + globalData.GetStepTime()) + "\t\tMinTemperature [°C]: " + min(t0) + "\t\tMaxTemperature [°C]: " + max(t0) + "\n");
            }
        }

        private void results_TextChanged(object sender, EventArgs e)
        {

        }

        private void showAllElementsButton_Click_1(object sender, EventArgs e)
        {
           
            for (int i = 1; i <= grid.GetElements().Length; i++)
            {
               Element element = grid.GetElements(i);
                results.Text += "Element id: " + element.id + " a ID jego wezlów: " + element.GetNode(0).id + " , "
                   + element.GetNode(1).id + " , " + element.GetNode(2).id + " , " + element.GetNode(3).id + "\n";
            }
            
        }
        private void showNodeByIdBox_Click_1(object sender, EventArgs e)
        {
            results.Text = "";
            string str_id_in = idBox.Text;
            int id_in = Convert.ToInt32(str_id_in);
            if (id_in <= grid.GetNodes().Length && id_in >= 1)
            {
                foreach (Node node in grid.GetNodes())
                {
                    if (node.id == id_in)
                    {
                        results.Text += "Wybrany wezel\n *********** \n Id: " + node.id + "\n X: " + node.x + " , \n Y: "
                       + node.y + " , \n T: " + node.t + " , \n BC: " + node.BC + "\n";
                    }
                }
            }
            else { results.Text = "Podano złe ID"; }
        }

        private void showElementByIdBox_Click_1(object sender, EventArgs e)
        {
            results.Text = "";
            string str_id_in = idBox.Text;
            int id_in = Convert.ToInt32(str_id_in);
            
            if (id_in <= grid.GetElements().Length && id_in >= 1)
            {
                foreach (Element element in grid.GetElements())
                {
                    if (element.id == id_in)
                    {
                        results.Text += "Wybrany element\n *********** \n Id: " + element.id + "\n Jego wezly: " + element.GetNode(0).id + " , "
                                         + element.GetNode(1).id + " , " + element.GetNode(2).id + " , " + element.GetNode(3).id;
                    }
                }
            }
            else { results.Text = "Podano złe ID"; }
        }

        private void showNodesOfElementByIdBox_Click_1(object sender, EventArgs e)
        {
            results.Text = "";
            string str_id_in = idBox.Text;
            int id_in = Convert.ToInt32(str_id_in);

            if (id_in <= grid.GetElements().Length && id_in >= 1)
            {
                foreach (Element element in grid.GetElements())
                {
                    if (element.id == id_in)
                    {
                        foreach (Node node in grid.GetNodes())
                        {
                            if (node.id == element.GetNode(0).id || node.id == element.GetNode(1).id || node.id == element.GetNode(2).id ||
                            node.id == element.GetNode(3).id)
                            {
                                results.Text += " ********************** \n Wybrany wezel\n ********************** \n Id: " + node.id + "\n X: " + node.x + " , \n Y: "
                                + node.y + " , \n T: " + node.t + " , \n BC: " + node.BC + "\n";
                            }
                        }
                    }
                }
            }
            else { results.Text = "Podano złe ID"; }
        }
        /*Pomocnicze Funkcje*/

        public static double max(double[] tab)
        {
            double max = Double.MinValue;
            foreach (double v in tab)
            {
                if (max < v) max = v;
            }
            return max;
        }

        public static double min(double[] tab)
        {
            double min = Double.MaxValue;
            foreach (double v in tab)
            {
                if (min > v) min = v;
            }
            return min;
        }

        
        
    }
}
