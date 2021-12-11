﻿using Microsoft.Win32;
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
        /*public void edytujucznia(string imieu, string drugieimieu, string nazwiskou, string nazwiskopanienskieu, string imionarodzicowu, string datauruu, string peselu, string plecu, string klasau, string grupau)
        {
            dynamic selected1 = ListView_Uczniowie.SelectedItem;
            imieu = selected1.Imie;
            drugieimieu = selected1.Drugie_imie;
            nazwiskou = selected1.Nazwisko;
            nazwiskopanienskieu = selected1.Nazwisko_panienskie;
            imionarodzicowu = selected1.Imiona_rodzicow;
            datauruu = selected1.Data_urodzenia;
            peselu = selected1.Pesel;
            plecu = selected1.Plec;
            klasau = selected1.Klasa;
            grupau = selected1.Grupa;


        }*/



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

        private void Btn_Usun_Click(object sender, RoutedEventArgs e)
        {
            ListView_Uczniowie.Items.Remove(ListView_Uczniowie.SelectedItem);
            ListView_Nauczyciele.Items.Remove(ListView_Nauczyciele.SelectedItem);
            ListView_Pracownicy.Items.Remove(ListView_Pracownicy.SelectedItem);


        }

        private void Btn_Zapisz_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl.SelectedIndex == 0) {

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
        }
    
    
}
