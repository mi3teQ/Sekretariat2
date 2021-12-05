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
using System.IO;
using Microsoft.Win32;
using System.Text.RegularExpressions;

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
            
            this.Close();
        }

        private void Btn_Dodaj_Click(object sender, RoutedEventArgs e)
        {

            //string[] row = { Txtbox_Imie.Text, Txtbox_Nazwisko.Text };
            //Txtbox_Imie.Text = "cos";
            string ImieU = Txtbox_Imie.Text;
            string DrugieimieU = Txtbox_Drugieimie.Text;
            string NazwiskoU = Txtbox_Nazwisko.Text;
            string nazwiskopanienskieu = Txtbox_nazwiskopanienskie.Text;
            string imionarodzicow = Txtbox_imionarodzicow.Text;
            string datauru = Datepicker_dataur.Text;
            string peselu = Txtbox_pesel.Text;
            string plecu = Txtbox_plec.Text;
            Sekretariat2.MainWindow.AppWindow.myFunc(ImieU, DrugieimieU, NazwiskoU, nazwiskopanienskieu, imionarodzicow, datauru, peselu, plecu);

            //MainWindow.ListView_Uczniowie.Items.Add(row);
        }

        private void Wybierz_zdjecie_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Wybierz zdjecie";
            if (op.ShowDialog() == true)
            {
                Fotka_Uczen.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void Txtbox_pesel_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        
    }
}
