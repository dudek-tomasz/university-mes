using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMES
{
    class UniversalElement
    {
        private double[] dEta;
        private double[] dKsi;
        private double[] shapeFun;

        public UniversalElement(double val1, double val2, double weight1, double weight2)
        {
            dEta = new double[4];
            dKsi = new double[4];
            shapeFun = new double[4];

            dEta[0] = -0.25 * (1 - val1);
            dEta[1] = -0.25 * (1 + val1);
            dEta[2] = 0.25 * (1 + val1);
            dEta[3] = 0.25 * (1 - val1);

            dKsi[0] = -0.25 * (1 - val2);
            dKsi[1] = 0.25 * (1 - val2);
            dKsi[2] = 0.25 * (1 + val2);
            dKsi[3] = -0.25 * (1 + val2);

            shapeFun[0] = 0.25 * (1 - val1) * (1 - val2);
            shapeFun[1] = 0.25 * (1 + val1) * (1 - val2);
            shapeFun[2] = 0.25 * (1 + val1) * (1 + val2);
            shapeFun[3] = 0.25 * (1 - val1) * (1 + val2);
        }

        public static UniversalElement[] CreateUniversalElements()
        {
            UniversalElement[] universalElements = new UniversalElement[4];
            universalElements[0] = new UniversalElement(-1 / Math.Sqrt(3), -1 / Math.Sqrt(3), 1, 1);
            universalElements[1] = new UniversalElement(1 / Math.Sqrt(3), -1 / Math.Sqrt(3), 1, 1);
            universalElements[2] = new UniversalElement(1 / Math.Sqrt(3), 1 / Math.Sqrt(3), 1, 1);
            universalElements[3] = new UniversalElement(-1 / Math.Sqrt(3), 1 / Math.Sqrt(3), 1, 1);
            return universalElements;
        }

        public double GetdEta(int x)
        {
            return dEta[x];
        }

        public double GetdKsi(int x)
        {
            return dKsi[x];
        }

        public double GetShapeFunction(int x)
        {
            return shapeFun[x];
        }

        public double[] GetDsEta()
        {
            return dEta;
        }

        public double[] GetDsKsi()
        {
            return dKsi;
        }

        public double[] GetShapeFun()
        {
            return shapeFun;
        }
    }
}
