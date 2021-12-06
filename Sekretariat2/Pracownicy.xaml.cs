using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Pracownicy.xaml
    /// </summary>
    public partial class Pracownicy : Window
    {
        public Pracownicy()
        {
            InitializeComponent();
        }

        private void Btn_powrot_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_dodaj_Click(object sender, RoutedEventArgs e)
        {

            string imiep = Txtbox_imiep.Text;
            string drugieimiep = Txtbox_drugieimiep.Text;
            string nazwiskop = Txtbox_nazwiskop.Text;
            string nazwiskopanienskiep = Txtbox_nazwiskopanienskiep.Text;
            string imionarodzicowp = Txtbox_imionarodzicowp.Text;
            string dataurp = Datepickerurp.Text;
            string peselp = Txtbox_peselp.Text;
            string plecp = Txtbox_plecp.Text;
            string etatp = Txtbox_etatp.Text;
            string opisstanowiskap = Txtbox_opisp.Text;
            string datazatrudnieniap = Datepickerzatrudnieniep.Text;

            Sekretariat2.MainWindow.AppWindow.dodajpracownika(imiep, drugieimiep, nazwiskop, nazwiskopanienskiep, imionarodzicowp, dataurp, peselp, plecp, etatp, opisstanowiskap, datazatrudnieniap);
        }

        private void Txtbox_peselp_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
