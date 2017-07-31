using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologo
{
    class Animales
    {
        private int cant;
        private float[] edad;

        public int Cant
        {
            get
            {
                return this.cant;
            }
            set
            {
                this.cant = value;
            }
        }
        public float[] Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public double[] porcentajeAnimales()
        {
            double[] aux = new double[3];
            for (int i = 0; i < aux.Length; i++)
            {
                aux[i] = 0;
            }
            for (int i = 0; i < this.edad.Length; i++)
            {



                if (this.edad[i] <= 1)
                {
                    aux[0]++;
                }
                else
                {
                    if (this.edad[i] < 3)
                    {
                        aux[1]++;
                    }
                    else
                    {
                        aux[2]++;
                    }
                }
            }
                aux[0] = (aux[0] * 100) / this.cant;
                aux[1] = (aux[1] * 100) / this.cant;
                aux[2] = (aux[2] * 100) / this.cant;
             
            return aux;
        }
    }
}
