using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMES
{
    class Node
    {
        public int id;
        public double x;
        public double y;
        public double t;
        public bool BC;

        public Node(int id, double x, double y, bool boundary, double temperature)
        {
            this.id = id;
            this.BC = boundary;
            this.t = temperature;
            this.x = x;
            this.y = y;
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        public double GetTemp()
        {
            return t;
        }

        public int GetId()
        {
            return id;
        }

        public bool IsBC()
        {
            return BC;
        }

        public void SetBC()
        {
            this.BC = true;
        }
        public void SetTemp(double temp)
        {
            this.t = temp;
        }
    }
}
