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

        private void szyfruj(object sender, RoutedEventArgs e)
        {
            int key;
            string text = tekst.Text;
            char[] alfabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'w', 'y', 'z'};
            if (klucz.Text == null)
            {
                key = 0;
            }
            else
            {
                key = int.Parse(klucz.Text);
            }

            zaszyfrowany_tekst.Text = key.ToString();
        }

        private void zapisz(object sender, RoutedEventArgs e)
        {

        }
    }
}
