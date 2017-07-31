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

namespace Promedio
{
    /// <summary>
    /// Lógica de interacción para ventana1.xaml
    /// </summary>
    public partial class ventana1 : Window
    {
        private TextBlock[] tb;
        private TextBox []num;
        private Button boton;
        private MainWindow m1;
        public ventana1(int cant,MainWindow m1)
        {
            InitializeComponent();
            tb = new TextBlock[cant];
            num = new TextBox[cant];
            for (int i = 0; i < tb.Length; i++)
            {
                tb[i] = new TextBlock();
                num[i] = new TextBox();
                tb[i].Text = "Ingrese el dato #"+(i+1);
                this.panel.Children.Add(tb[i]);
                this.panel.Children.Add(num[i]);
            }
            this.boton = new Button();
            boton.Content = "Calcular";
            boton.Click += boton1_Click_1;
            this.m1 = m1;
            this.panel.Children.Add(boton);
        }
        private void boton1_Click_1(object sender, RoutedEventArgs e)
        {
            double aux;
            double[] aux2 = new double[this.num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                if (double.TryParse(this.num[i].Text, out aux))
                {
                    aux2[i] = aux;
                }
                else
                {
                    return;
                }
            }
            Numeros nu = new Numeros();
            nu.Num = aux2;
            aux = nu.CalcularPromedio();
            MessageBox.Show(aux.ToString());
            
        }
    }
}
