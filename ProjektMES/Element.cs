using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMES
{
    class Element
    {
        public Node[] nodes = new Node[4];
        public int id;

        public Element(int id, Node n1, Node n2, Node n3, Node n4)
        {
            this.nodes[0] = n1;
            this.nodes[1] = n2;
            this.nodes[2] = n3;
            this.nodes[3] = n4;
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public Node[] GetNodes()
        {
            return nodes;
        }

        public Node GetNode(int localNodeId)
        {
            return nodes[localNodeId];
        }

        public bool IsContactedSurface(int surfaceId)
        {
            return nodes[surfaceId].IsBC() && nodes[(surfaceId + 1) % 4].IsBC();
        }

        public double GetSurfaceLength(int surfaceId)
        {
            double val1, val2;
            if (surfaceId % 2 == 0)
            {
                val1 = nodes[surfaceId].GetX();
                val2 = nodes[(surfaceId + 1) % 4].GetX();
            }
            else
            {
                val1 = nodes[surfaceId].GetY();
                val2 = nodes[(surfaceId + 1) % 4].GetY();
            }
            return Math.Abs(val2 - val1);
        }

        public double[,] GetSurfaceMatrixH(int surfaceID, double alfa)
        {
            IntPoint pkt1 = new IntPoint(-1 / Math.Sqrt(3));
            IntPoint pkt2 = new IntPoint(1 / Math.Sqrt(3));
            double[,] pcMatrix1 = pkt1.GetPcMatrix(alfa);
            double[,] pcMatrix2 = pkt2.GetPcMatrix(alfa);
            double det = this.GetSurfaceLength(surfaceID) / 2;
            return MatrixOperations.multiply(MatrixOperations.addition(pcMatrix1, pcMatrix2), new double[] { det });
        }

        public double[,] GetPointMatrixH(Jacobian jacobian, double conductivity)
        {
            double[] dndx = jacobian.GetdNdx();
            double[] dndy = jacobian.GetdNdy();
            double det = jacobian.GetDetJ();
            double[,] tmpdndx = MatrixOperations.multiply(dndx, MatrixOperations.transpose(dndx), det);
            double[,] tmpdndy = MatrixOperations.multiply(dndy, MatrixOperations.transpose(dndy), det);
            return MatrixOperations.multiply(MatrixOperations.addition(tmpdndx, tmpdndy), new double[] { conductivity });
        }

        public double[,] GetPointMatrixC(UniversalElement universalElement, double det, double specificHeat, double density)
        {
            double[] shapeFunctions = universalElement.GetShapeFun();
            return MatrixOperations.multiply(shapeFunctions, MatrixOperations.transpose(shapeFunctions), det * specificHeat * density);
        }

        public double[,] GetMatrixHbc(double alfa)
        {
            double[,] h = new double[4,4];

            for (int surfaceID = 0; surfaceID < 4; surfaceID++)
            {
                if (this.IsContactedSurface(surfaceID))
                {
                    double[,] result = this.GetSurfaceMatrixH(surfaceID, alfa);
                    for (int id1 = 0; id1 < 2; id1++)
                    {
                        for (int id2 = 0; id2 < 2; id2++)
                        {
                            h[(id1 + surfaceID) % 4,(id2 + surfaceID) % 4] += result[id1,id2];
                        }
                    }
                }
            }
            return h;
        }

        public double[] GetSurfaceVectorP(int surfaceID, double alfa, double ambientTemperature)
        {
            IntPoint pkt1 = new IntPoint(-1 / Math.Sqrt(3));
            IntPoint pkt2 = new IntPoint(1 / Math.Sqrt(3));
            double[] n1 = pkt1.GetNVector();
            double[] n2 = pkt2.GetNVector();
            double det = this.GetSurfaceLength(surfaceID) / 2;
            return MatrixOperations.multiply(MatrixOperations.addition(n1, n2), new double[] { alfa, ambientTemperature,  det });
        }

        public double[] getVectorP(double alfa, double ambientTemperature)
        {
            double[] p = new double[4];

            for (int surfaceID = 0; surfaceID < 4; surfaceID++)
            {
                if (this.IsContactedSurface(surfaceID))
                {
                    double[] result = this.GetSurfaceVectorP(surfaceID, alfa, ambientTemperature);
                    for (int id = 0; id < 2; id++)
                    {
                        p[(id + surfaceID) % 4] += result[id];
                    }
                }
            }
            return p;
        }
    }
}
