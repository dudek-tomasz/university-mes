using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMES
{
    class IntPoint
    {
        double ksi;

        public IntPoint(double ksi)
        {
            this.ksi = ksi;
        }

        public double[] GetNVector()
        {
            double[] n = new double[2];
            n[0] = (1 - ksi) / 2;
            n[1] = (1 + ksi) / 2;
            return n;
        }

        public double[,] GetPcMatrix(double alfa)
        {
            double[] n = GetNVector();
            return MatrixOperations.multiply(n, MatrixOperations.transpose(n), alfa);
        }
    }
}
