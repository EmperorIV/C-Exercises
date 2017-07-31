using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corredor
{
    class Tiempo
    {
        private float[] tiempos;

        public float[] Tiempos
        {
            get
            {
                return this.tiempos;
            }
            set
            {
                this.tiempos = value;
            }
        }

        public bool competencia()
        {
            float aux = 0;
            bool a = true;

            foreach (var tiempo in this.tiempos)
            {
                Console.Write(tiempo);
                if (tiempo > 16)
                {
                    a = false;
                   return true;
                }
                else
                {
                    aux = aux+ tiempo;
                   
                }
            
            }
            aux /= tiempos.Length;
            if ((aux<15 && aux>0) || a)
            {
                return true;
            }
            return false;
        }
    }
}
