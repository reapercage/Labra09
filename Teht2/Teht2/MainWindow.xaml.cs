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

namespace Teht2
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

        double euro;
        double markka;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            markka = System.Convert.ToDouble(textBox1.Text);
            euro = markka / 5.94573;
            textBox.Text = euro.ToString("0.00");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            euro = System.Convert.ToDouble(textBox.Text);
            markka = euro * 5.94573;
            textBox1.Text = markka.ToString("0.00");
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
