﻿using System;
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

namespace Tehtav1
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

        int rekka = 0;
        int auto = 0;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            rekka++;
            textBlock.Text = rekka.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            auto++;
            textBlock1.Text = auto.ToString();

        }
    }
}
