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

namespace Egzamin_2025_czerwiec
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

        public void szyfruj(object sender, RoutedEventArgs e)
        {
            int key;
            string text = tekst.Text; 
            if (klucz.Text == null)
            {
                key = 0;
            }
            else
            {
                key = int.Parse(klucz.Text)%26;
            }
            string wynik = szyfrCezara(text, key);
            zaszyfrowany_tekst.Text = wynik;
        }

        public string szyfrCezara(string text, int key)
        {
            char[] litery = text.ToCharArray();
            char[] alfabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char spracja = ' ';
            for (int i = 0; i < text.Length; i++)
            {
                if (litery[i] == spracja)
                {
                    litery[i] = spracja;
                }
                else
                {
                    int pozycja = Array.IndexOf(alfabet, text[i]);
                    litery[i] = alfabet[pozycja + key];
                }

            }
            text = new string(litery);
            return text;
        }

        private void zapisz(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
