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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Promedio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void boton1_Click_1(object sender, RoutedEventArgs e)
        {
            double n,aux;
            int aux3=0;
            double resultado = 0;
            if ( double.TryParse(this.caja1.Text, out aux)){
             n = aux;
                aux3 = Convert.ToInt32(n);
            }
            else{
                if (this.caja1.Text.Equals("0")){
                    MessageBox.Show("no se puede con 0");
                }
                else{
                MessageBox.Show("No ingreso nado o numero no valido");
                }

            }
            ventana1 v1 = new ventana1( (aux3), this);
            v1.Show();
            
        }

        private void boton2_Click_1(object sender, RoutedEventArgs e)
        {
            double n, aux;
            int aux3 = 0;
            double resultado = 0;
            if (double.TryParse(this.caja1.Text, out aux))
            {
                n = aux;
                aux3 = Convert.ToInt32(n);
            }
            else
            {
                if (this.caja1.Text.Equals("0"))
                {
                    MessageBox.Show("no se puede con 0");
                }
                else
                {
                    MessageBox.Show("No ingreso nado o numero no valido");
                }

            }
            Numeros num = new Numeros();
            MessageBox.Show(num.calcularSumatoria(aux3).ToString());

        }

        private void boton3_Click_1(object sender, RoutedEventArgs e)
        {
            double n, aux;
            int aux3 = 0;
            double resultado = 0;
            if (double.TryParse(this.caja1.Text, out aux))
            {
                n = aux;
                aux3 = Convert.ToInt32(n);
            }
            else
            {
                if (this.caja1.Text.Equals("0"))
                {
                    MessageBox.Show("no se puede con 0");
                }
                else
                {
                    MessageBox.Show("No ingreso nado o numero no valido");
                }

            }
            Numeros num = new Numeros();
            MessageBox.Show(num.calcularFactorial(aux3).ToString());
        }
    }
}
