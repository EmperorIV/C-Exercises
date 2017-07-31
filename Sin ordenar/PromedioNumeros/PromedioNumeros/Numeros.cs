using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNumeros
{
    class Numeros
    {
        private double[] num;
        public double[] Num { get {
            return this.num;
        } set {
            this.num = value;
        } }
        public double calcularPromedio()
        {
            double aux = 0;
            foreach (var valores in this.num)
            {
                aux += valores;
            }
            aux /= this.num.Length;
            return aux;
        }
    }
}
