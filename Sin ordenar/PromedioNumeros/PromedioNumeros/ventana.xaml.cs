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

namespace PromedioNumeros
{
    /// <summary>
    /// Lógica de interacción para ventana.xaml
    /// </summary>
    public partial class ventana : Window
    {
        public TextBlock[] texto;
        public TextBox [] numeros;
        public Button b1;
        public MainWindow mw;

        public ventana(int cant, MainWindow m1)
        {
            InitializeComponent();
            this.texto = new TextBlock[cant];
            this.numeros = new TextBox[cant];

            for (int i = 0; i < texto.Length; i++)
            {
                texto[i] = new TextBlock();
                numeros[i] = new TextBox();
                texto[i].Text = "digite el numero  " + (i + 1);
              this.panel.Children.Add(texto[i]);
                this.panel.Children.Add(numeros[i]);
            
            }
            this.b1 = new Button();
            b1.Content = "enviar";
            b1.Click += enviar_Click_1;
            this.panel.Children.Add(b1);
            this.mw = m1;
            

        }
        private void enviar_Click_1(object sender, RoutedEventArgs e)
        {
            double aux;
            double[] aux2 = new double[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (double.TryParse(this.numeros[i].Text, out aux))
                {
                    aux2[i] = aux;
                }
                else
                {
                    MessageBox.Show("ingrese todos los campos");
                }
                
            }
            Numeros num = new Numeros();
            num.Num = aux2;
            MessageBox.Show("El promedio es"+num.calcularPromedio());
            this.mw.Show();
            this.Close();
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            this.mw.Show();
        }
    }
}
