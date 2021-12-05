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
            Sekretariat2.MainWindow.AppWindow.dodajnauczyciel(imieN);
        }
    }
}
