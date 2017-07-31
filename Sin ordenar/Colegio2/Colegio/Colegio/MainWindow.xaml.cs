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

namespace Colegio
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

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            
    
            this.Hide();
            Window1 w1 = new Window1(int.Parse(this.caja1.Text), double.Parse(this.caja2.Text),this);
            w1.Show();          
        }
        private void callBack()
        {
            this.Show();
        }
    }
}
