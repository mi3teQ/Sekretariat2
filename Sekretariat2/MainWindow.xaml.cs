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

        public void myFunc(string imieu, string drugieimieu, string nazwiskou, string nazwiskopanienskieu, string imionarodzicowu, string datauruu, string peselu, string plecu, string klasau, string grupau)
        {
            //MessageBox.Show("cos");
            ListView_Uczniowie.Items.Add(new { Imie = imieu, Drugie_imie = drugieimieu, Nazwisko = nazwiskou, Nazwisko_panienskie = nazwiskopanienskieu, Imiona_rodzicow = imionarodzicowu, Data_urodzenia = datauruu, Pesel = peselu, Plec = plecu, Klasa = klasau, Grupa = grupau});
        }
        public void dodajnauczyciel(string imien, string drugieimien, string nazwiskon, string nazwiskopanienskien, string imionardzicown, string dataurn, string peseln, string plecn, string wychowawstwon, string przedmiotyn, string klasynaczuane, string wybierzdate)
        {
            ListView_Nauczyciele.Items.Add(new {Imien = imien, Drugie_imien = drugieimien, Nazwiskon = nazwiskon, Nazwisko_panienskien = nazwiskopanienskien, Imiona_rodzicown = imionardzicown, Data_urodzenian = dataurn, Peseln = peseln, Plecn = plecn, Wychowawstwon = wychowawstwon, Przedmiotyn = przedmiotyn, Klasy_nauczanen = klasynaczuane, Data_zatrudnienian  = wybierzdate});
        }
        public void dodajpracownika()
        {
            ListView_Pracownicy.Items.Add(new { });
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

       
    }
}
