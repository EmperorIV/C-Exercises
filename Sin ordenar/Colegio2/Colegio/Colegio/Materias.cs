using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{

    class Materias
    {
        private double[] notasMaterias;
        private double precio;


        public double[] NotasMaterias
        {
            get { return this.notasMaterias; }
            set { this.notasMaterias = value; }
        }
        public double Precio {
            get{ return this.precio; }
            set { this.precio = value; } }

        public double calcularPromedio()
        {
            double aux = 0;
            foreach (var item in this.notasMaterias)
            {
                aux += item;
            }
            return aux / this.notasMaterias.Length;
        }

        public String totalPagar()
        {
            double aux = calcularPromedio();
            if (aux<=9)
            {
                return ("Su promedio fue "+aux+"\n Debe pagar colegiatura completa por el valor de:"+((this.precio*this.notasMaterias.Length)*1.1));
            }
            else{
                return ("Su promedio fue" + aux + "\n Tiene un descuento en la colegiatura debe pagar el valor de : " + ((this.precio * this.notasMaterias.Length) * 0.7));
            }
        }
    }
}
