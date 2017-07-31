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
        public TextBox [] edad;
        public TextBox[] peso;
        public Button b1;
        public MainWindow mw;

        public ventana(int cant, MainWindow m1)
        {
            InitializeComponent();
            this.texto = new TextBlock[cant];
            this.edad = new TextBox[cant];
            this.peso = new TextBox[cant];
            for (int i = 0; i < texto.Length; i++)
            {
                texto[i] = new TextBlock();
                edad[i] = new TextBox();
                peso[i] = new TextBox();
                texto[i].Text = "digite la edad  " + (i + 1);
              this.panel.Children.Add(texto[i]);
              this.panel.Children.Add(edad[i]);
              texto[i] = new TextBlock();
              texto[i].Text = "digite el peso  " + (i + 1);
              this.panel.Children.Add(texto[i]);
              this.panel.Children.Add(peso[i]); 

               
            
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
            double[] aux2 = new double[peso.Length];
            for (int i = 0; i < peso.Length; i++)
            {
                if (double.TryParse(this.peso[i].Text, out aux))
                {
                    aux2[i] = aux;
                }
                else
                {
                    MessageBox.Show("ingrese todos los campos");
                }
                
            }
            int aux3;
            int[] aux4 = new int[edad.Length];
            for (int i = 0; i < edad.Length; i++)
            {
                if (int.TryParse(this.edad[i].Text, out aux3))
                {
                    aux4[i] = aux3;
                }
                else
                {
                    MessageBox.Show("ingrese todos los campos");
                }

            }
            Persona num = new Persona();
            num.Peso = aux2;
            num.Edad = aux4;
            num.calcularPromedio();
            MessageBox.Show("El promedio de menores de 12 es" + num.Promedio[0] + "\n El promedio de menores de 24 es "+num.Promedio[1] +
               "\n El promedio de menores de 50 es" + num.Promedio[2] + "\n El promedio de mayores de 50 es"+ num.Promedio[3]);
            this.mw.Show();
            this.Close();
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            this.mw.Show();
        }
    }
}
