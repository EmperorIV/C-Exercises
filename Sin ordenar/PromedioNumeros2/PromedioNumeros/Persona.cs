using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNumeros
{
    class Persona
    {
        private double[] peso;
        private int[] edad;
        private double[] promedio = new double[4];
        public double[] Peso { get {
            return this.peso;
        } set {
            this.peso = value;
        } }

        public int[] Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public double[] Promedio 
        {
            get { return this.promedio; }
            set { this.promedio = value; }        
        }
        public void calcularPromedio()
        {
            int aux1 = 0, aux2 = 0, aux3 = 0, aux4 = 0;
            for (int i = 0; i < promedio.Length; i++)
            {
                promedio[i] = 0;
                
            }
            for (int i = 0; i < this.peso.Length; i++)
            {
                if (this.edad[i]<12)
                {
                    promedio[0] += this.peso[i];
                    aux1++;
                }
                else
                {
                    if (this.edad[i]<24)
                    {
                        promedio[1] += this.peso[i];
                        aux2++;
                    }
                    else
                    {
                        if (this.edad[i] < 50)
                        {
                            promedio[2] += this.peso[i];
                            aux3++;
                        }
                        else
                        {
                            promedio[3] += this.peso[i];
                            aux4++;
                        }
                        promedio[0] /= aux1;
                        promedio[1] /= aux2;
                        promedio[2] /= aux3;
                        promedio[3] /= aux4;
                    }
                }
            }
        }
    }
}
