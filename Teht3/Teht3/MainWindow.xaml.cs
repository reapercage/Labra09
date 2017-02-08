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

namespace Teht3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double leveys;
        double korkeus;
        double karmi;
        double pinta_ala;
        double ipinta_ala;
        double piiri;

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //muunnetaan milleistä senteiksi
            leveys = 0.1 * System.Convert.ToDouble(ileveys.Text);
            korkeus = 0.1 * System.Convert.ToDouble(ikorkeus.Text);
            karmi = 0.1 * System.Convert.ToDouble(karmileveys.Text);
            //laskutoimitukset
            pinta_ala = leveys * korkeus;
            ipinta_ala = (leveys - karmi * 2) * (korkeus - karmi * 2);
            piiri = leveys * 2 + korkeus * 2;

            ipinta.Text = pinta_ala.ToString("0.00") + " cm^2";
            lasipinta.Text = ipinta_ala.ToString("0.00") + " cm^2";
            karmipiiri.Text = piiri.ToString("0.00") + " cm";
        }
    }
}
