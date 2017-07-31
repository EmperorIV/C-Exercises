using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Numeros
    {
        private double[] num;

        public double[] Num {
            get
            {
                return this.num;
            }
            set
            {
                this.num = value;
            }
        }

        public double CalcularPromedio()
        {
            double aux = 0;
            foreach (var item in num)
            {
                aux += item;
            }
            return aux / this.num.Length;
        }
        public double calcularFactorial(int a)
        {
            int test = 1;
            for (int i = 1; i <= a; i++)
            {
                test *= i;
            }
            return test;
        }
        public double calcularSumatoria(int a)
        {
            int test = 0;
            for (int i = 0; i <= a; i++)
            {
                test += i;
            }
            return test;
        }

    }
}
