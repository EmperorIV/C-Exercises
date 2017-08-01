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
using System.Threading;
using System.Windows.Threading;

namespace Memoria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    
        private const int alto = 4 ,ancho = 4;      
        private int puntaje = 0, aux = 0, aux1 = 0;
        private int posx, posy;
        private Button [,] botones;
        private Grid[,] ph;
        private Image[,] imagenes;           
        private int cont,acertados,fallidos, segs,mins;
        private TextBlock[,] tb;
        private DispatcherTimer dispatcherTimer ;
        private System.Media.SoundPlayer sonido;
       


        public MainWindow()
        {
            //
            sonido = new System.Media.SoundPlayer();
          
            //
            segs = 0;
            mins = 0;            
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            acertados = fallidos = cont = 0;
            InitializeComponent();
            Numeros num = new Numeros();
            this.Acertados.Text= "0";
            this.Fallidos.Text = "0";
            botones = new Button[alto,ancho];
            ph = new Grid[alto, ancho];
            imagenes = new Image[alto, ancho];
            tb = new TextBlock[alto, ancho];

            for (int i = 0; i < alto; i++)
              {
                  for (int j = 0; j < ancho; j++)
                  {
                    botones[i, j] = new Button();
                    int aux = num.darNumero();
                    Grid.SetColumn(botones[i, j], i);
                    Grid.SetRow(botones[i, j], j);
                    this.panel.Children.Add(botones[i, j]);
                    ph[i,j] = new Grid();

                    tb[i, j] = new TextBlock();
                    tb[i, j].Visibility = Visibility.Collapsed;
                    tb[i, j].Text = aux.ToString();

                    botones[i, j].Content = ph[i, j];
                    imagenes[i,j] = new Image();
                    imagenes[i, j].Source = new BitmapImage(new Uri(num.conseguirImagen(aux), UriKind.Relative));
                    imagenes[i, j].Visibility = Visibility.Collapsed;
                    ph[i, j].Children.Add(imagenes[i, j]);
                    botones[i, j].Foreground = new SolidColorBrush(Colors.Transparent);
                    botones[i, j].Click += Button_Click_1;
                  }
              }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        
        {

            imagenes[Grid.GetColumn(((Button)sender)), Grid.GetRow(((Button)sender))].Visibility = Visibility.Visible;

            cont++;
            this.UpdateLayout();
            if (aux == 0)
            {
                aux = int.Parse(tb[Grid.GetColumn(((Button)sender)), Grid.GetRow(((Button)sender))].Text);
                posx = Grid.GetColumn((Button)sender);
                posy = Grid.GetRow((Button)sender);
                ((Button)sender).IsEnabled = false;
            }

            else
            {
                aux1 = int.Parse(tb[Grid.GetColumn(((Button)sender)), Grid.GetRow(((Button)sender))].Text);
            }
            if (cont == 2)
            {
                await Task.Delay(500);
                if (aux == aux1)
                {
                    puntaje += 50;

                    ((Button)sender).IsEnabled = false;

                    botones[posx, posy].IsEnabled = false;
                    acertados++;
                    this.Acertados.Text = acertados.ToString();
                    sonido = new System.Media.SoundPlayer(Memoria.Properties.Resources.punto);
                       sonido.Play();
                    
                }
                else
                {
                    botones[posx, posy].IsEnabled = true;
                    puntaje -= 10;
                    imagenes[Grid.GetColumn(((Button)sender)), Grid.GetRow(((Button)sender))].Visibility = Visibility.Collapsed;
                    imagenes[posx, posy].Visibility = Visibility.Collapsed;
                    fallidos++;
                    this.Fallidos.Text = fallidos.ToString();
                    sonido = new System.Media.SoundPlayer(Memoria.Properties.Resources.error);
                    sonido.Load();
                    sonido.Play();
                    
                }
                if (acertados == 1)
                {
                    dispatcherTimer.Stop();                   
                  
                    MessageBox.Show("Usted ha ganado puntaje final" + puntaje);
                    sonido = new System.Media.SoundPlayer(Properties.Resources.punto);
                    sonido.Load();
                    sonido.Play();

                }

               
                cont = 0;
                aux = 0;
                aux1 = 0;

            }
               
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           MainWindow m1 = new MainWindow();
           m1.Show();
           this.Close();
        }
        private void tick(object sender, EventArgs e)
        {
            segs++;
            if (segs==60)
            {
                segs = 0;
                mins++;
            }
            
            this.Tiempo.Text = mins + ":" + segs;
        }
    }
       
    }

