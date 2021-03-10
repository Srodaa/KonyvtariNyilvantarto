using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace KonyvtariNyilvantarto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Konyvek> AKonyvek = new List<Konyvek>();
        List<DemeterBela> ATagok = new List<DemeterBela>();
        List<Kolcsonzes> Akolcsonzes = new List<Kolcsonzes>();
        public MainWindow()
        {
            InitializeComponent();
            Beolvasas("konyvek.txt");
            Tagok("tagok.txt");
            Kolcsonzes("kolcsonzesek.txt");

        }

        public void Beolvasas(string nev)
        {
            datagrid.ItemsSource = AKonyvek;
            foreach (var item in File.ReadAllLines(nev))
            {
                AKonyvek.Add(new Konyvek(item));
            }
        }

        public void Tagok(string nev)
        {
            EMBEREKdatagrid.ItemsSource = ATagok;
            foreach (var item in File.ReadAllLines(nev))
            {
                ATagok.Add(new DemeterBela(item));
            }
        }

        public void Kolcsonzes(string nev)
        {
            KOLCSONZESdatagrid.ItemsSource = Akolcsonzes;
            foreach (var item in File.ReadAllLines(nev))
            {
                Akolcsonzes.Add(new Kolcsonzes(item));
            }
        }

        private void konyvkereso_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (konyvkereso.Text == "")
            {
                datagrid.ItemsSource = AKonyvek;
            }
            else
            {
                var filtered = AKonyvek.Where(x => x.KIro.StartsWith(konyvkereso.Text) || x.KKiadasEve.StartsWith(konyvkereso.Text) || x.KKonyvCime.StartsWith(konyvkereso.Text) || x.KKiado.StartsWith(konyvkereso.Text));

                datagrid.ItemsSource = filtered;
            }



        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = AKonyvek;
            var x = datagrid;
            if (datagrid.SelectedIndex>=0)
            {
                AKonyvek.RemoveAt(x.SelectedIndex);
                x.Items.Refresh();
            }
        }

        private void hozzaad_Click(object sender, RoutedEventArgs e)
        {
            Konyvek Uj = new Konyvek("");
            Uj.KKonyvID = AKonyvek.Count + 1;
            Uj.KIro = konyviro.Text;
            Uj.KKonyvCime = konyvcim.Text;
            Uj.KKiadasEve = konyvkiadasdatuma.Text;
            Uj.KKiado = konyvkiado.Text;
            Uj.KKolcsonzes = true;
            AKonyvek.Add(Uj);
            datagrid.ItemsSource = AKonyvek;
        }
    }
}
