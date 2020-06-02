using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMES
{
    class MatrixOperations
    {
        
        public static double[,] transpose(double[,] matrix)
        {
            double[,] temp = new double[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    temp[j,i] = matrix[i,j];
            return temp;
        }

        public static double[,] transpose(double[] matrix)
        {
            double[,] temp = new double[matrix.GetLength(0), 1];
            for (int i = 0; i < matrix.GetLength(0); i++)
                temp[i,0] = matrix[i];
            return temp;
        }

        public static double[] multiply(double[] m, double[] scalars)
        {
            if (m == null) return null;
            double[] mResult = new double[m.Length];
            for (int i = 0; i < m.Length; i++)
            {         // rows from m
                mResult[i] = m[i];
                foreach (double scalar in scalars)
                {
                    mResult[i] *= scalar;
                }
            }
            return mResult;
        }

        public static double[,] multiply(double[,] m, double[]scalars)
        {
            if (m == null) return null;
            double[,] mResult = new double[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < m.GetLength(0); i++)
            {         // rows from m
                for (int j = 0; j < m.GetLength(1); j++)
                {     // columns from m
                    mResult[i,j] = m[i,j];
                    foreach (double scalar in scalars)
                    {
                        mResult[i,j] *= scalar;
                    }
                }
            }
            return mResult;
        }

        public static double[,] multiply(double[,] m1, double[,] m2, double[]scalars)
        {
            if (m1.GetLength(1) != m2.GetLength(0)) return null; // matrix multiplication is not possible
            double[,] mResult = new double[m1.GetLength(0),m1.GetLength(1)];
            for (int i = 0; i < m1.GetLength(0); i++)
            {         // rows from m1
                for (int j = 0; j < m2.GetLength(1); j++)
                {     // columns from m2
                    for (int k = 0; k < m1.GetLength(1); k++)
                    { // columns from m1
                        mResult[i,j] += m1[i,k] * m2[k,j];
                        foreach (double scalar in scalars)
                        {
                            mResult[i,j] *= scalar;
                        }
                    }
                }
            }
            return mResult;
        }

        public static double[,] multiply(double[] m1, double[,] m2, double scalar)
        {
            if (m1 == null || m2 == null) return null;
            if (m1.Length != m2.GetLength(0)) return null; // matrix multiplication is not possible
            double[,] mResult = new double[m1.Length,m2.GetLength(0)];
            for (int i = 0; i < m1.Length; i++)
            {         // rows from m1
                for (int j = 0; j < m2.GetLength(0); j++)
                {     // columns from m2
                    mResult[i,j] += m1[i] * m2[j,0] * scalar;
                }
            }
            return mResult;
        }

        public static double[] multiply(double[,] m1, double[] m2, double scalar)
        {
            if (m1 == null || m2 == null) return null;
            if (m1.GetLength(0) != m2.Length) return null; // matrix multiplication is not possible
            double[] mResult = new double[m1.GetLength(1)];
            for (int i = 0; i < m1.GetLength(1); i++)
            {     // columns from m2
                for (int j = 0; j < m2.Length; j++)
                { // columns from m1
                    mResult[i] += m1[j,i] * m2[j] * scalar;
                }
            }
            return mResult;
        }

        public static double[,] addition(double[,] m1, double[,] m2)
        {
            if (m1 == null || m2 == null) return null;
            if (m1.GetLength(0) != m2.GetLength(0) || m1.GetLength(1) != m2.GetLength(1)) return null;
            double[,] mResult = new double[m1.GetLength(0),m1.GetLength(1)];
            for (int i = 0; i < m1.GetLength(0); i++)
            {         // rows from m
                for (int j = 0; j < m1.GetLength(1); j++)
                {     // columns from m
                    mResult[i,j] += m1[i,j] + m2[i,j];
                }
            }
            return mResult;
        }

        public static double[] addition(double[] m1, double[] m2)
        {
            if (m1 == null || m2 == null) return null;
            if (m1.Length != m2.Length) return null;
            double[] mResult = new double[m1.Length];
            for (int i = 0; i < m1.Length; i++)
            {         // rows from m
                mResult[i] += m1[i] + m2[i];
            }
            return mResult;
        }

        public static double determinant(double[,] matrix)
        {
            double sum = 0;
            double s;
            if (matrix.GetLength(0) == 1)
            {
                return (matrix[0,0]);
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double[,] smaller = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
                for (int a = 1; a < matrix.GetLength(0); a++)
                {
                    for (int b = 0; b < matrix.GetLength(0); b++)
                    {
                        if (b < i)
                        {
                            smaller[a - 1,b] = matrix[a,b];
                        }
                        else if (b > i)
                        {
                            smaller[a - 1,b - 1] = matrix[a,b];
                        }
                    }
                }
                if (i % 2 == 0)
                {
                    s = 1;
                }
                else
                {
                    s = -1;
                }
                sum += s * matrix[0,i] * (determinant(smaller));
            }
            return (sum);
        }

        public static double[,] inverse(double[,] matrix)
        {
            double[,] inverse = new double[matrix.GetLength(0), matrix.GetLength(0)];

            // minors and cofactors
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    inverse[i,j] = Math.Pow(-1, i + j) * determinant(minor(matrix, i, j));

            // adjugate and determinant
            double det = 1.0 / determinant(matrix);
            for (int i = 0; i < inverse.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    double temp = inverse[i,j];
                    inverse[i,j] = inverse[j,i] * det;
                    inverse[j,i] = temp * det;
                }
            }

            return inverse;
        }

        public static double[,] minor(double[,] matrix, int row, int column)
        {
            double[,] minor = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; i != row && j < matrix.GetLength(1); j++)
                    if (j != column) minor[i < row ? i : i - 1,j < column ? j : j - 1] = matrix[i,j];
            return minor;
        }

        public static double[] gaussianElimination(double[,] H, double[] b)
        {
            double EPSILON = 1e-10;

            int nodeNumber = H.GetLength(0);

            int n = b.Length;
            double[,] A = new double[nodeNumber, nodeNumber];

            for (int i = 0; i < nodeNumber; i++)
            {
                for (int j = 0; j < nodeNumber; j++)
                {
                    A[i, j]=H[i, j];                    
                }
                
            }

            for (int p = 0; p < n; p++)
            {
                // find pivot row and swap
                int max = p;
                for (int i = p + 1; i < n; i++)
                {
                    if (Math.Abs(A[i,p]) > Math.Abs(A[max,p]))
                    {
                        max = i;
                    }
                }

                double[] temp =new double[nodeNumber];
                for (int j = 0; j < nodeNumber; j++)
                {
                    temp[j] = A[p,j];
                    A[p,j] = A[max,j];
                    A[max,j] = temp[j];
                }
                
                
                
                double t = b[p];
                b[p] = b[max];
                b[max] = t;

                // singular or nearly singular
                if (Math.Abs(A[p,p]) <= EPSILON)
                {
                    throw new ArithmeticException("Matrix is singular or nearly singular");
                }

                // pivot within A and b
                for (int i = p + 1; i < n; i++)
                {
                    double alpha = A[i,p] / A[p,p];
                    b[i] -= alpha * b[p];
                    for (int j = p; j < n; j++)
                    {
                        A[i,j] -= alpha * A[p,j];
                    }
                }
            }

            // back substitution
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0.0;
                for (int j = i + 1; j < n; j++)
                {
                    sum += A[i,j] * x[j];
                }
                x[i] = (b[i] - sum) / A[i,i];
            }
            return x;
        }
    }
}
