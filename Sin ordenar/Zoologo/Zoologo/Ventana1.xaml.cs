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

namespace Zoologo
{
    /// <summary>
    /// Lógica de interacción para Ventana1.xaml
    /// </summary>
    public partial class Ventana1 : Window
    {
        private TextBlock[] texto;
        private TextBox[] edades;
        private Button b1;
        private String animal;
        private MainWindow m1;
        public Ventana1(int cant,String animal, MainWindow m1)
        {
            InitializeComponent();
            texto = new TextBlock[cant];
            edades = new TextBox[cant];

            for (int i = 0; i < texto.Length; i++)
            {
                texto[i] = new TextBlock();
                texto[i].Text = "Ingrese la edad del " + animal + " #"+(i+1);
                edades[i] = new TextBox();
                this.panel.Children.Add(texto[i]);
                this.panel.Children.Add(edades[i]);
            }
            b1 = new Button();
            b1.Content = "enviar";
            b1.Click += Enviar_Click_1;
            this.panel.Children.Add(b1);
            this.m1 = m1;
            this.animal = animal;

        }
        private void Enviar_Click_1(object sender, RoutedEventArgs e)
        {
            float aux;
            float [] aux2 = new float[edades.Length];
            for (int i = 0; i < edades.Length; i++)
            {
                if (float.TryParse(this.edades[i].Text, out aux))
                {
                    aux2[i] = aux;
                }
                else
                {
                    MessageBox.Show("ingrese todos los campos o campo invalido");
                }
            }
            Animales an = new Animales();
            an.Edad = aux2;
            an.Cant = this.edades.Length;

            var aux3 = an.porcentajeAnimales();
            MessageBox.Show("Los porcentajes de  "+this.animal+" son: \n"+
                             "Menores de 1 año :"+aux3[0]+"\n"+
                             "mayores de 1 año y menores de 3 "+aux3[1]+
                             "\n Mayores de 3 años :"+aux3[2]);
            //this.m1.Show();
           // this.Close();
        }
    }
}
