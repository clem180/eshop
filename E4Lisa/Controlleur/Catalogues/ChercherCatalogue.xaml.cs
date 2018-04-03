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

namespace E4Lisa.Controlleur.Catalogues
{
    /// <summary>
    /// Logique d'interaction pour ChercherCatalogue.xaml
    /// </summary>
    public partial class ChercherCatalogue : UserControl
    {
        public ChercherCatalogue()
        {
            InitializeComponent();
        }
        private void chercher_Click(object sender, RoutedEventArgs e)
        {
            Windows.Catalogues.GestiondescataloguesRechercher GDCR = new Windows.Catalogues.GestiondescataloguesRechercher(chercherCatalogue.Text);
            GDCR.Show();
        }
    }
}
