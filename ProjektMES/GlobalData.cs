using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMES
{
    class GlobalData
    {
        private double initTemp;    
        private double symTime;        
        private double symStepTime;       
        private double ambientTemp;     
        private double alfa;       
        private double H;           
        private double B;          
        private int nH;            
        private int nB;             
        private double specHeat;          
        private double conductivity;           
        private double density;           

        private int numberOfNodes;              
        private int numberOfElements;              

       public GlobalData(double initTemp, double symTime, double symStepTime, double ambientTemp, double alpha, double H, double B, int nH, int nB, double specHeat, double conductivity, double density)
        {
            this.initTemp = initTemp;
            this.symTime = symTime;
            this.symStepTime = symStepTime;
            this.ambientTemp = ambientTemp;
            this.alfa = alpha;
            this.H = H;
            this.B = B;
            this.nH = nH;
            this.nB = nB;
            this.specHeat = specHeat;
            this.conductivity = conductivity;
            this.density = density;

            this.numberOfElements = (this.nB - 1) * (this.nH - 1);
            this.numberOfNodes = this.nB * this.nH;
        }

        public double GetInitTemp()
        {
            return initTemp;
        }

        public double GetSymTime()
        {
            return symTime;
        }

        public double GetStepTime()
        {
            return symStepTime;
        }

        public double GetAmbientTemp()
        {
            return ambientTemp;
        }

        public double GetAlfa()
        {
            return alfa;
        }

        public double GetHeight()
        {
            return H;
        }

        public double GetWidth()
        {
            return B;
        }

        public int GetNHeight()
        {
            return nH;
        }

        public int GetNWidth()
        {
            return nB;
        }

        public double GetSpecificHeat()
        {
            return specHeat;
        }

        public double GetConductivity()
        {
            return conductivity;
        }

        public double GetDensity()
        {
            return density;
        }

        public int GetNumberOfNodes()
        {
            return numberOfNodes;
        }

        public int GetNumberOfElements()
        {
            return numberOfElements;
        }
    }
}
