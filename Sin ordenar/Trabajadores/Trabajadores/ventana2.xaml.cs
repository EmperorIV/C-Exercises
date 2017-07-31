using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Trabajadores
{
    /// <summary>
    /// Lógica de interacción para ventana2.xaml
    /// </summary>
    public partial class ventana2 : Window
    {
        public ventana2(Trabajador[] trabajador)
        {
            DataContext = trabajador;
            InitializeComponent();

            String aux= "";
            for (int i = 0; i < trabajador.Length; i++)
            {
                aux += "El trabajador #"+i+" trabajo "+trabajador[i].HorasTrabajadas+" horas y devenga ";
                aux += trabajador[i].Sueldo + " \n";
            }
            this.caja1.Text = aux;

        }
    }
}
