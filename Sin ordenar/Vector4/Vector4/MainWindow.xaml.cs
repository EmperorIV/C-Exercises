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

namespace Vector4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock[] tv1 = new TextBlock[4], tv2 = new TextBlock[4];
        TextBox[] v1 = new TextBox[4], v2  = new TextBox[4];
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i <  v1.Length; i++)
            {
                tv1[i] = new TextBlock();
                tv1[i].Text = "Ingrese valor vector 1 posicion #"+i;

                tv2[i] = new TextBlock();
                tv2[i].Text = "Ingrese valor vector 2 posicion #" + i;

                v1[i] = new TextBox();
                
                v2[i] = new TextBox();

                this.panel1.Children.Add(this.tv1[i]);
                this.panel1.Children.Add(this.v1[i]);

                this.panel2.Children.Add(this.tv2[i]);
                this.panel2.Children.Add(this.v2[i]);
               

            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double aux,aux2;
            double[] val = new double[v1.Length];
            double[] val2 = new double[v1.Length];
            for (int i = 0; i < v1.Length; i++)
			{
                if (double.TryParse(this.v1[i].Text, out aux) && double.TryParse(this.v2[i].Text, out aux2))
                {
                    val[i] = aux;
                    val2[i] = aux2;
                }
                else {
                    return;
                }
			 
			}
            Vectores vectores = new Vectores();
            vectores.Vector1 = val;
            vectores.Vector2 = val2;
            vectores.cargarVector3();
            String a = "";
            for (int i = 0; i < vectores.Vector3.Length; i++)
            {
                a += "en la posicion " + i + " el vector tiene el valor de " + vectores.Vector3[i] + " \n";
            }
            MessageBox.Show(a);
        }
    }
}
