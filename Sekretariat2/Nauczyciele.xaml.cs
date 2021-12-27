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
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace Sekretariat2
{
    /// <summary>
    /// Interaction logic for Nauczyciele.xaml
    /// </summary>
    public partial class Nauczyciele : Window
    {
        public Nauczyciele()
        {
            InitializeComponent();
        }

        private void Btn_powrot_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_dodaj_Click(object sender, RoutedEventArgs e)
        {
            string imieN = Txtbox_imien.Text;
            string drugieimien = Txtbox_drugieimien.Text;
            string nazwiskon = Txtbox_nazwiskon.Text;
            string nazwiskopanienskien = Txtbox_nazwiskopanienskien.Text;
            string imionarodzicown = Txtbox_imionarodzicown.Text;
            string dataurn = Datepickern.Text;
            string peseln = Txtbox_peseln.Text;
            string plecn = txtbox_plecn.Text;
            string wychowawstwon = Txtbox_wychowawstwon.Text;
            string przedmiotyn = Txtbox_przedmiotyn.Text;
            string klasynauczanen = Txtbox_klasynaczuanen.Text;
            string wybierzdate = wybierzdaten.Text; 
            Sekretariat2.MainWindow.AppWindow.dodajnauczyciel(imieN, drugieimien, nazwiskon, nazwiskopanienskien, imionarodzicown, dataurn, peseln, plecn, wychowawstwon, przedmiotyn, klasynauczanen, wybierzdate);
        }

        private void Txtbox_peseln_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void btn_zdjecie_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Wybierz zdjecie";
            if (op.ShowDialog() == true)
            {
                zdjecienauczyciel.Source = new BitmapImage(new Uri(op.FileName));
            }
        }
    }
}
