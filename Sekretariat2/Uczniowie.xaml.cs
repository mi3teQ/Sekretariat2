using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sekretariat2
{
    /// <summary>
    /// Interaction logic for Uczniowie.xaml
    /// </summary>
    public partial class Uczniowie : Window
    {
        public Uczniowie()
        {
            InitializeComponent();
        }

        private void Btn_Wroc_Click(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void Btn_Dodaj_Click(object sender, RoutedEventArgs e)
        {
            
            //string[] row = { Txtbox_Imie.Text, Txtbox_Nazwisko.Text };

            Sekretariat2.MainWindow.AppWindow.myFunc("Zdzichu");

            //MainWindow.ListView_Uczniowie.Items.Add(row);
        }
    }
}
