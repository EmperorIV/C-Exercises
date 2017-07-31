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

namespace Colegio
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private TextBox []cajas;
        private TextBlock[] texto;
        private Button b1;    
        private Materias mat;
        private MainWindow m1;
        public Window1(int cant , double precio, MainWindow m1)
        {
            this.mat = new Materias();          
            InitializeComponent();
            this.mat.Precio = precio;
            this.cajas = new TextBox[cant];
            this.texto = new TextBlock[cant];
            for (int i = 0; i < cant; i++)
                
            {
                texto[i] = new TextBlock();
                texto[i].Text = "Ingrese la materia #"+(i+1);
                this.panel.Children.Add(texto[i]);
                
                cajas[i] = new TextBox();
                this.panel.Children.Add(cajas[i]);    
                
            }
            this.b1 = new Button();
            this.b1.Content = "Enviar";
            this.b1.Click += Enviar_Click;
            this.panel.Children.Add(b1);
            this.m1 = m1;
            
        }

        private void Enviar_Click(object sender, RoutedEventArgs e)
        {
                 
            double [] aux  = new double [this.cajas.Length];
            double a;
            for (int i = 0; i < this.cajas.Length; i++)
            {
                if (double.TryParse(this.cajas[i].Text, out a))
                {
                    aux[i] = a;
                }
                else
                {
                    MessageBox.Show("revise todos los campos");                    
                    return;
                }
            }
            mat.NotasMaterias = aux;
            MessageBox.Show(mat.totalPagar());
            this.Close();
            this.m1.Show();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.m1.Show();
        }
    }
}
