using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMES
{
    class Grid
    {
        Node[] nodes;
        Element[] elements;

        public Grid(GlobalData data)
        {
            this.CreateNodes(data);
            this.CreateElements(data);
        }

        private void CreateNodes(GlobalData data)
        {
            double dy = data.GetHeight() / (data.GetNHeight() - 1);
            double dx = data.GetWidth() / (data.GetNWidth() - 1);
            int id = 0;
            double x = 0, y;
            nodes = new Node[data.GetNumberOfNodes()];
            for (int i = 0; i < data.GetNWidth(); i++)
            {
                y = 0;
                for (int j = 0; j < data.GetNHeight(); j++)
                {
                    id++;
                    Node node = new Node(id, x, y, false, data.GetInitTemp());
                    if (x > data.GetWidth() - dx / 2 || x == 0 || y > data.GetWidth() - dx / 2 || y == 0)
                        node.SetBC();
                    nodes[i + data.GetNWidth() * j] = node;
                    y = y + dy;
                }
                x = x + dx;
            }
        }

        private void CreateElements(GlobalData data)
        {
            elements = new Element[data.GetNumberOfElements()];
            int i1, i2, i3, i4;
            int id = 0;
            for (int i = 0; i < data.GetNWidth() - 1; i++)
            {
                for (int j = 0; j < data.GetNHeight() - 1; j++)
                {
                    id++;
                    i1 = i * data.GetNHeight() + j + 1;
                    i2 = (i + 1) * data.GetNHeight() + j + 1;
                    i3 = (i + 1) * data.GetNHeight() + j + 1 + 1;
                    i4 = i * data.GetNHeight() + j + 1 + 1;
                    elements[i + (data.GetNWidth() - 1) * j] = new Element(id, GetNodes(i1), GetNodes(i2), GetNodes(i3), GetNodes(i4));
                }
            }
        }

        public Node GetNodes(int id)
        {
            Node node = null;
            foreach (Node n in nodes)
            {
                if (n.GetId() == id) node = n;
            }
            return node;
        }

        public Element GetElements(int id)
        {
            Element element = null;
            foreach (Element n in elements)
            {
                if (n.GetId() == id) element = n;
            }
            return element;
        }
        public Element[] GetElements()
        {
            return this.elements;
        }

        public Node[] GetNodes()
        {
            return this.nodes;
        }

        public double[] GetTemperatures()
        {
            double[] t0 = new double[nodes.Length];
            for (int i = 0; i < nodes.Length; i++)
            {
                t0[i] = nodes[i].GetTemp();
            }
            return t0;
        }

        public void SetTemperatures(double[] temperatures)
        {
            foreach (Node n in nodes)
            {
                n.SetTemp(temperatures[n.GetId() - 1]);
            }
        }
    }
}
