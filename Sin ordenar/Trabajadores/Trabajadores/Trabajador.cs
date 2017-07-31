using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajadores
{
    public class Trabajador
    {
        private int horasTrabajadas;
        private double sueldo;
        private const double valorSueldo = 10000;

        public int HorasTrabajadas {
            get
            {
                return this.horasTrabajadas;
            }
            set
            {
                this.horasTrabajadas = value;
            }
        }

        public double Sueldo {
            get {
                return this.sueldo;
            }
            set
            {
                this.sueldo = value;
            }
        }

        public void calcularSueldo()
        {
            this.sueldo = (this.horasTrabajadas * valorSueldo);
        }
    }
}
