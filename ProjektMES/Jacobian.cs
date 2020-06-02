using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMES
{
    class Jacobian
    {
        private double det;
        public double[,] inverseJacobian;
        private double[] dNdx;
        private double[] dNdy;

        public Jacobian(Element element, UniversalElement universalElement)
        {
            double[,] tab = new double[2,2];
            for (int i = 0; i < element.GetNodes().Length; i++)
            {
                tab[0,0] += universalElement.GetdKsi(i) * element.GetNode(i).GetX();
                tab[0,1] += universalElement.GetdKsi(i) * element.GetNode(i).GetY();
                tab[1,0] += universalElement.GetdEta(i) * element.GetNode(i).GetX();
                tab[1,1] += universalElement.GetdEta(i) * element.GetNode(i).GetY();
            }
            det = MatrixOperations.determinant(tab);
            inverseJacobian = MatrixOperations.inverse(tab);
            dNdx = new double[4];
            dNdy = new double[4];
            for (int i = 0; i < 4; i++)
            {
                dNdx[i] = GetInverseJacobian()[0,0] * universalElement.GetdKsi(i) - GetInverseJacobian()[0,1] * universalElement.GetdEta(i);
                dNdy[i] = -GetInverseJacobian()[1,0] * universalElement.GetdKsi(i) + GetInverseJacobian()[1,1] * universalElement.GetdEta(i);
            }
        }

        public double GetDetJ()
        {
            return det;
        }

        public double[,] GetInverseJacobian()
        {
            return inverseJacobian;
        }

        public double[] GetdNdx()
        {
            return dNdx;
        }

        public double[] GetdNdy()
        {
            return dNdy;
        }
    }
}
