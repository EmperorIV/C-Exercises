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

namespace Corredor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int dias = 7;
        private TextBlock[] tb1;
        private TextBox[] tiempo;
        private Button b1;
        public MainWindow()
        {
            InitializeComponent();
            tb1 = new TextBlock[dias];
            tiempo = new TextBox[dias];
            for (int i = 0; i < tb1.Length; i++)
            {
                tb1[i] = new TextBlock();
                tb1[i].Text = "Ingrese el tiempo del dia #" + (i + 1);
                tiempo[i] = new TextBox();
                this.panel.Children.Add(tb1[i]);
                this.panel.Children.Add(tiempo[i]);

            }
            this.b1 = new Button();
            b1.Content = "enviar";
            b1.Click += enviar_Click;
            this.panel.Children.Add(b1);

        }
        private void enviar_Click(object sender, RoutedEventArgs e)
        {
            float[] aux = new float[dias];
            float aux2;
            for (int i = 0; i < dias; i++)
            {
                if(float.TryParse(this.tiempo[i].Text, out aux2))
                {
                    aux[i] = aux2;
                }
            }
            Tiempo ti = new Tiempo();
            
            ti.Tiempos = aux;
            if (ti.competencia())
            {
                MessageBox.Show("Puede competir");
            }
            else
            {
                MessageBox.Show("No puede compentir");
            }
        }
    }
}
