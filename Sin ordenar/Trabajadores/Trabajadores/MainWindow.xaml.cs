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

namespace Trabajadores
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

        private void enviar_Click(object sender, RoutedEventArgs e)
        {
            int aux;
            if (int.TryParse(this.caja1.Text, out aux))
            {
                ventana1 v1 = new ventana1(aux, this);
                v1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ingrese un numero valido");
            }
        }
    }
}
