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

namespace Zoologo
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

        private void Enviar_Click_1(object sender, RoutedEventArgs e)
        {
            int cant = 0;
            String text = ((ComboBoxItem)(this.animales.SelectedItem)).Content.ToString();
            if (text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar algun tipo de animal");
                return;
            }
            if (text.Equals("Elefantes"))
            {
                cant = 20;
            }
            else
            {
                if (text.Equals("Jirafas"))
                {
                    cant = 5;
                }
                else 
                {
                    cant = 40;
                }
            }
            Ventana1 v1 = new Ventana1(cant,text,this);
            v1.Show();
            this.Close();

        }
    }
}
