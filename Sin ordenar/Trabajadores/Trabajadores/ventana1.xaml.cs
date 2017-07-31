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
    /// Lógica de interacción para ventana1.xaml
    /// </summary>
    public partial class ventana1 : Window
    {
        TextBlock[] text;
        TextBox[] horas;
        Button enviar;
        MainWindow mn;
        public ventana1(int cantidad, MainWindow mw)
        {
            InitializeComponent();
            text = new TextBlock[cantidad];
            horas = new TextBox[cantidad];
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = new TextBlock();
                text[i].Text = "Ingrese las horas trabajadas por el trabajador "+(i+1);
                this.panel.Children.Add(text[i]);
                horas[i] = new TextBox();
                this.panel.Children.Add(horas[i]);               

            }
            enviar = new Button();
            enviar.Content = "Enviar";
            enviar.Click += enviar_Click;
            this.panel.Children.Add(enviar);
            this.mn = mw;
        }
        private void enviar_Click(object sender, RoutedEventArgs e)
        {
            int aux;
            Trabajador[] tra = new Trabajador[horas.Length];
            for (int i = 0; i < this.horas.Length; i++)
            {
                if(int.TryParse(this.horas[i].Text, out aux))
                {
                    tra[i] = new Trabajador();
                    tra[i].HorasTrabajadas = aux;
                    tra[i].calcularSueldo();
                }
                else
                {
                    MessageBox.Show("Existe un campo invalido o vacio");
                    return;
                }
                
            }
            ventana2 v2 = new ventana2(tra);
            v2.Show();
        }
    }
}
