using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        Regex regex;
        public static MainWindow AppWindow;

        public MainWindow()
        {
            InitializeComponent();
            AppWindow = this;

        }

        public void myFunc(string imieu, string drugieimieu, string nazwiskou, string nazwiskopanienskieu, string imionarodzicowu, string datauruu, string peselu, string plecu, string klasau, string grupau)
        {
            //MessageBox.Show("cos");
            ListView_Uczniowie.Items.Add(new { Imie = imieu, Drugie_imie = drugieimieu, Nazwisko = nazwiskou, Nazwisko_panienskie = nazwiskopanienskieu, Imiona_rodzicow = imionarodzicowu, Data_urodzenia = datauruu, Pesel = peselu, Plec = plecu, Klasa = klasau, Grupa = grupau });
        }
        public void dodajnauczyciel(string imien, string drugieimien, string nazwiskon, string nazwiskopanienskien, string imionardzicown, string dataurn, string peseln, string plecn, string wychowawstwon, string przedmiotyn, string klasynaczuane, string wybierzdate)
        {
            ListView_Nauczyciele.Items.Add(new { Imien = imien, Drugie_imien = drugieimien, Nazwiskon = nazwiskon, Nazwisko_panienskien = nazwiskopanienskien, Imiona_rodzicown = imionardzicown, Data_urodzenian = dataurn, Peseln = peseln, Plecn = plecn, Wychowawstwon = wychowawstwon, Przedmiotyn = przedmiotyn, Klasy_nauczanen = klasynaczuane, Data_zatrudnienian = wybierzdate });
        }
        public void dodajpracownika(string imiep, string drugieimiep, string nazwiskop, string nazwiskopanienskiep, string imionarodzicowp, string dataurp, string peselp, string plecp, string etatp, string opissatnowiskap, string datazatrudnieniap)
        {
            ListView_Pracownicy.Items.Add(new { Imiep = imiep, Drugie_Imiep = drugieimiep, Nazwiskop = nazwiskop, Nazwisko_panienskiep = nazwiskopanienskiep, Imiona_rodzicowp = imionarodzicowp, Data_urodzeniap = dataurp, Peselp = peselp, Plecp = plecp, Etatp = etatp, Opis_stanowiskap = opissatnowiskap, Data_zatrudnieniap = datazatrudnieniap });
        }




        private void Btn_Dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                var Uczniowie = new Uczniowie();
                Uczniowie.Show();
                //this.Close();
                Uczniowie.Btn_Dodaj.Visibility = Visibility.Visible;
                Uczniowie.Btn_zapisz.Visibility = Visibility.Hidden;
            }
            if (TabControl.SelectedIndex == 1)
            {
                var Nauczyciele = new Nauczyciele();
                Nauczyciele.Show();
                //this.Close();
                Nauczyciele.Btn_dodaj.Visibility = Visibility.Visible;
                Nauczyciele.Btn_zapisz.Visibility = Visibility.Hidden;
            }
            if (TabControl.SelectedIndex == 2)
            {
                var Pracownicy = new Pracownicy();
                Pracownicy.Show();
                //this.Close();
                Pracownicy.Btn_dodaj.Visibility = Visibility.Visible;
                Pracownicy.Btn_zapisz.Visibility = Visibility.Hidden;
            }

        }

        private void Btn_Zmien_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {



                var Uczniowie = new Uczniowie();
                Uczniowie.Show();
                dynamic selected1 = ListView_Uczniowie.SelectedItem;



                var imieu = selected1.Imie;
                var drugieimieu = selected1.Drugie_imie;
                var nazwiskou = selected1.Nazwisko;
                var Nazwiskopanienskieu = selected1.Nazwisko_panienskie;
                var Imionarodzicowu = selected1.Imiona_rodzicow;
                var Dataurodzeniau = selected1.Data_urodzenia;
                var Peselu = selected1.Pesel;
                var Plecu = selected1.Plec;
                var Klasau = selected1.Klasa;
                var Grupau = selected1.Grupa;

                Uczniowie.Txtbox_Imie.Text = imieu;
                Uczniowie.Txtbox_Drugieimie.Text = drugieimieu;
                Uczniowie.Txtbox_Nazwisko.Text = nazwiskou;
                Uczniowie.Txtbox_nazwiskopanienskie.Text = Nazwiskopanienskieu;
                Uczniowie.Txtbox_imionarodzicow.Text = Imionarodzicowu;
                //Uczniowie.Datepicker_dataur.SelectedDate = Dataurodzeniau;
                Uczniowie.Txtbox_pesel.Text = Peselu;
                Uczniowie.Txtbox_plec.Text = Plecu;
                Uczniowie.Txtbox_klasa.Text = Klasau;
                Uczniowie.Txtbox_grupa.Text = Grupau;
                Uczniowie.Btn_Dodaj.Visibility = Visibility.Hidden;
                Uczniowie.Btn_zapisz.Visibility = Visibility.Visible;

            }
            if (TabControl.SelectedIndex == 1)
            {
                var Nauczyciele = new Nauczyciele();
                Nauczyciele.Show();
                dynamic selected2 = ListView_Nauczyciele.SelectedItem;
                Nauczyciele.Btn_dodaj.Visibility = Visibility.Hidden;
                Nauczyciele.Btn_zapisz.Visibility = Visibility.Visible;
                var imieu = selected2.Imien;
                var drugieimieu = selected2.Drugie_imien;
                var nazwiskou = selected2.Nazwiskon;
                var Nazwiskopanienskieu = selected2.Nazwisko_panienskien;
                var Imionarodzicowu = selected2.Imiona_rodzicown;
                var Dataurodzeniau = selected2.Data_urodzenian;
                var Peselu = selected2.Peseln;
                var Plecu = selected2.Plecn;
                var wychowastow = selected2.Wychowawstwon;
                var przedmioty = selected2.Przedmiotyn;
                var klasynauczane = selected2.Klasy_nauczanen;
                var datazatr = selected2.Data_zatrudnienian;

                Nauczyciele.Txtbox_imien.Text = imieu;
                Nauczyciele.Txtbox_drugieimien.Text = drugieimieu;
                Nauczyciele.Txtbox_nazwiskon.Text = nazwiskou;
                Nauczyciele.Txtbox_nazwiskopanienskien.Text = Nazwiskopanienskieu;
                Nauczyciele.Txtbox_imionarodzicown.Text = Imionarodzicowu;
                // Nauczyciele.Datepickern.SelectedDate = Dataurodzeniau;
                Nauczyciele.Txtbox_peseln.Text = Peselu;
                Nauczyciele.txtbox_plecn.Text = Plecu;
                Nauczyciele.Txtbox_wychowawstwon.Text = wychowastow;
                Nauczyciele.Txtbox_przedmiotyn.Text = przedmioty;
                Nauczyciele.Txtbox_klasynaczuanen.Text = klasynauczane;
                //Nauczyciele.wybierzdaten.SelectedDate = datazatr;


            }
            if (TabControl.SelectedIndex == 2)
            {
                var Pracownicy = new Pracownicy();
                Pracownicy.Show();

                dynamic selected1 = ListView_Pracownicy.SelectedItem;
                Pracownicy.Btn_dodaj.Visibility = Visibility.Hidden;
                Pracownicy.Btn_zapisz.Visibility = Visibility.Visible;
                var imieu = selected1.Imiep;
                var drugieimieu = selected1.Drugie_Imiep;
                var nazwiskou = selected1.Nazwiskop;
                var Nazwiskopanienskieu = selected1.Nazwisko_panienskiep;
                var Imionarodzicowu = selected1.Imiona_rodzicowp;
                var Dataurodzeniau = selected1.Data_urodzeniap;
                var Peselu = selected1.Peselp;
                var Plecu = selected1.Plecp;
                var etat = selected1.Etatp;
                var opisstanowiska = selected1.Opis_stanowiskap;
                var datazatr = selected1.Data_zatrudnieniap;


                Pracownicy.Txtbox_imiep.Text = imieu;
                Pracownicy.Txtbox_drugieimiep.Text = drugieimieu;
                Pracownicy.Txtbox_nazwiskop.Text = nazwiskou;
                Pracownicy.Txtbox_nazwiskopanienskiep.Text = Nazwiskopanienskieu;
                Pracownicy.Txtbox_imionarodzicowp.Text = Imionarodzicowu;
                //Pracownicy.Datepickerurp.SelectedDate = Dataurodzeniau;
                Pracownicy.Txtbox_peselp.Text = Peselu;
                Pracownicy.Txtbox_plecp.Text = Plecu;
                Pracownicy.Txtbox_etatp.Text = etat;
                Pracownicy.Txtbox_opisp.Text = opisstanowiska;
                //Pracownicy.Datepickerzatrudnieniep.SelectedDate = datazatr;
            }
        }

        private void Btn_Usun_Click(object sender, RoutedEventArgs e)
        {
            ListView_Uczniowie.Items.Remove(ListView_Uczniowie.SelectedItem);
            ListView_Nauczyciele.Items.Remove(ListView_Nauczyciele.SelectedItem);
            ListView_Pracownicy.Items.Remove(ListView_Pracownicy.SelectedItem);


        }

        private void Btn_Zapisz_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Txt file|*.txt";
                if (dialog.ShowDialog() == true)


                    using (StreamWriter theWriter = new StreamWriter(dialog.FileName))
                    {

                        {
                            foreach (var item in ListView_Uczniowie.Items)
                            {
                                dynamic selected1 = item;
                                var imieu = selected1.Imie;
                                var drugieimieu = selected1.Drugie_imie;
                                var nazwiskou = selected1.Nazwisko;
                                var Nazwiskopanienskieu = selected1.Nazwisko_panienskie;
                                var Imionarodzicowu = selected1.Imiona_rodzicow;
                                var Dataurodzeniau = selected1.Data_urodzenia;
                                var Peselu = selected1.Pesel;
                                var Plecu = selected1.Plec;
                                var Klasau = selected1.Klasa;
                                var Grupau = selected1.Grupa;


                                theWriter.Write(imieu + "," + drugieimieu + "," + nazwiskou + "," + Nazwiskopanienskieu + "," + Imionarodzicowu + "," + Dataurodzeniau + "," + Peselu + "," + Plecu + "," + Klasau + "," + Grupau + "\n");

                            }
                        }
                    }
            }
            if (TabControl.SelectedIndex == 1)
            {
                SaveFileDialog dialog1 = new SaveFileDialog();
                dialog1.Filter = "Txt file|*.txt";
                if (dialog1.ShowDialog() == true)
                    using (StreamWriter theWriter = new StreamWriter(dialog1.FileName))
                    {

                        {
                            foreach (var item in ListView_Nauczyciele.Items)
                            {
                                dynamic selected1 = item;
                                var imieu = selected1.Imien;
                                var drugieimieu = selected1.Drugie_imien;
                                var nazwiskou = selected1.Nazwiskon;
                                var Nazwiskopanienskieu = selected1.Nazwisko_panienskien;
                                var Imionarodzicowu = selected1.Imiona_rodzicown;
                                var Dataurodzeniau = selected1.Data_urodzenian;
                                var Peselu = selected1.Peseln;
                                var Plecu = selected1.Plecn;
                                var wychowastow = selected1.Wychowawstwon;
                                var przedmioty = selected1.Przedmiotyn;
                                var klasynauczane = selected1.Klasy_nauczanen;
                                var datazatr = selected1.Data_zatrudnienian;


                                theWriter.Write(imieu + "," + drugieimieu + "," + nazwiskou + "," + Nazwiskopanienskieu + "," + Imionarodzicowu + "," + Dataurodzeniau + "," + Peselu + "," + Plecu + "," + wychowastow + "," + przedmioty + "," + klasynauczane + "," + datazatr + "\n");

                            }
                        }
                    }
            }
            if (TabControl.SelectedIndex == 2)
            {
                SaveFileDialog dialog2 = new SaveFileDialog();
                dialog2.Filter = "Txt file|*.txt";
                if (dialog2.ShowDialog() == true)
                    using (StreamWriter theWriter = new StreamWriter(dialog2.FileName))
                    {

                        {
                            foreach (var item in ListView_Nauczyciele.Items)
                            {
                                dynamic selected1 = item;
                                var imieu = selected1.Imiep;
                                var drugieimieu = selected1.Drugie_Imiep;
                                var nazwiskou = selected1.Nazwiskop;
                                var Nazwiskopanienskieu = selected1.Nazwisko_panienskiep;
                                var Imionarodzicowu = selected1.Imiona_rodzicowp;
                                var Dataurodzeniau = selected1.Data_urodzeniap;
                                var Peselu = selected1.Peselp;
                                var Plecu = selected1.Plecp;
                                var etat = selected1.Etatp;
                                var opisstanowiska = selected1.Opis_stanowiskap;
                                var datazatr = selected1.Data_zatrudnieniap;



                                theWriter.Write(imieu + "," + drugieimieu + "," + nazwiskou + "," + Nazwiskopanienskieu + "," + Imionarodzicowu + "," + Dataurodzeniau + "," + Peselu + "," + Plecu + "," + etat + "," + opisstanowiska + "," + datazatr + "\n");

                            }
                        }
                    }

            }
        }

        private void Txtbox_szukaj_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                {
                    FindListViewItem(ListView_Uczniowie);
                }
            }
            if (TabControl.SelectedIndex == 1)
            {
                {
                    FindListViewItem(ListView_Nauczyciele);
                }
            }
            if (TabControl.SelectedIndex == 2)
            {
                {
                    FindListViewItem(ListView_Pracownicy);
                }
            }
        }

        private void FindListViewItem(DependencyObject obj)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                ListViewItem lv = obj as ListViewItem;
                if (lv != null)
                {
                    HighlightText(lv);
                }
                FindListViewItem(VisualTreeHelper.GetChild(obj as DependencyObject, i));
            }
        }

        private void HighlightText(Object itx)
        {
            if (itx != null)
            {
                if (itx is TextBlock)
                {
                    regex = new Regex("(" + Txtbox_szukaj.Text + ")", RegexOptions.IgnoreCase);
                    TextBlock tb = itx as TextBlock;
                    if (Txtbox_szukaj.Text.Length == 0)
                    {
                        string str = tb.Text;
                        tb.Inlines.Clear();
                        tb.Inlines.Add(str);
                        return;
                    }
                    string[] substrings = regex.Split(tb.Text);
                    tb.Inlines.Clear();
                    foreach (var item in substrings)
                    {
                        if (regex.Match(item).Success)
                        {
                            Run runx = new Run(item);
                            runx.Background = Brushes.Red;
                            tb.Inlines.Add(runx);
                        }
                        else
                        {
                            tb.Inlines.Add(item);
                        }
                    }
                    return;
                }
                else
                {
                    for (int i = 0; i < VisualTreeHelper.GetChildrenCount(itx as DependencyObject); i++)
                    {
                        HighlightText(VisualTreeHelper.GetChild(itx as DependencyObject, i));
                    }
                }
            }
        }




        private void LoadTextIntoListView(ListView listView)
        {

        }



        private void Btn_Zaladuj_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "TXT files|*.txt";
                var dialogResult = ofd.ShowDialog();
                if (dialogResult == true)

                {
                    foreach (var line in System.IO.File.ReadLines(ofd.FileName))
                    {



                        ListView_Uczniowie.Items.Add(new { Imie = line.ToString().Split(',')[0].ToString(), Drugie_imie = line.ToString().Split(',')[1].ToString(), Nazwisko = line.ToString().Split(',')[2].ToString(), Nazwisko_panienskie = line.ToString().Split(',')[3].ToString(), Imiona_rodzicow = line.ToString().Split(',')[4].ToString(), Data_urodzenia = line.ToString().Split(',')[5].ToString(), Pesel = line.ToString().Split(',')[6].ToString(), Plec = line.ToString().Split(',')[7].ToString(), Klasa = line.ToString().Split(',')[8].ToString(), Grupa = line.ToString().Split(',')[9].ToString() });



                    }

                }
            }
            if (TabControl.SelectedIndex == 1)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "TXT files|*.txt";
                var dialogResult = ofd.ShowDialog();
                if (dialogResult == true)

                {
                    foreach (var line in System.IO.File.ReadLines(ofd.FileName))
                    {



                        ListView_Nauczyciele.Items.Add(new { Imien = line.ToString().Split(',')[0].ToString(), Drugie_imien = line.ToString().Split(',')[1].ToString(), Nazwiskon = line.ToString().Split(',')[2].ToString(), Nazwisko_panienskien = line.ToString().Split(',')[3].ToString(), Imiona_rodzicown = line.ToString().Split(',')[4].ToString(), Data_urodzenian = line.ToString().Split(',')[5].ToString(), Peseln = line.ToString().Split(',')[6].ToString(), Plecn = line.ToString().Split(',')[7].ToString(), Wychowawstwon = line.ToString().Split(',')[8].ToString(), Przedmiotyn = line.ToString().Split(',')[9].ToString(), Klasy_nauczanen = line.ToString().Split(',')[10].ToString(), Data_zatrudnienian = line.ToString().Split(',')[11].ToString() });



                    }

                }
            }
                if (TabControl.SelectedIndex == 2)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "TXT files|*.txt";
                    var dialogResult = ofd.ShowDialog();
                    if (dialogResult == true)

                    {
                        foreach (var line in System.IO.File.ReadLines(ofd.FileName))
                        {



                        ListView_Pracownicy.Items.Add(new { Imiep = line.ToString().Split(',')[0].ToString(), Drugie_Imiep = line.ToString().Split(',')[1].ToString(), Nazwiskop = line.ToString().Split(',')[2].ToString(), Nazwisko_panienskiep = line.ToString().Split(',')[3].ToString(), Imiona_rodzicowp = line.ToString().Split(',')[4].ToString(), Data_urodzeniap = line.ToString().Split(',')[5].ToString(), Peselp = line.ToString().Split(',')[6].ToString(), Plecp = line.ToString().Split(',')[7].ToString(), Etatp = line.ToString().Split(',')[8].ToString(), Opis_stanowiskap = line.ToString().Split(',')[9].ToString(), Data_zatrudnieniap = line.ToString().Split(',')[10].ToString() });



                    }

                    }
                }
            }
        }
    }

    



