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

namespace Sekretariat2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    
    public partial class MainWindow : Window
    {

        public static MainWindow AppWindow;
        public MainWindow()
        {
            InitializeComponent();
            AppWindow = this;

        }

        public void myFunc(string imien, string drugieimien, string nazwiskou, string nazwiskopanienskieu, string imionarodzicowu)
        {
            //MessageBox.Show("cos");
            ListView_Uczniowie.Items.Add(new { Imie = imien, Drugie_imie = drugieimien, Nazwisko = nazwiskou, Nazwisko_panienskie = nazwiskopanienskieu, Imiona_Rodzicow = imionarodzicowu});
        }

        private void Btn_Dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                var Uczniowie = new Uczniowie();
                Uczniowie.Show();
                //this.Close();
            }
            if (TabControl.SelectedIndex == 1)
            {
                var Nauczyciele = new Nauczyciele();
                Nauczyciele.Show();
                //this.Close();
            }
            if (TabControl.SelectedIndex == 2)
            {
                var Pracownicy = new Pracownicy();
                Pracownicy.Show();
                //this.Close();
            }
            
        }

        private void Btn_Zmien_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                var Uczniowie = new Uczniowie();
                Uczniowie.Show();
                this.Close();
            }
            if (TabControl.SelectedIndex == 1)
            {
                var Nauczyciele = new Nauczyciele();
                Nauczyciele.Show();
                this.Close();
            }
            if (TabControl.SelectedIndex == 2)
            {
                var Pracownicy = new Pracownicy();
                Pracownicy.Show();
                this.Close();
            }
        }
    }
}
