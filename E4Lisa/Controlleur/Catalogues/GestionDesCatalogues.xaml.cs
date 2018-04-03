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
    /// Logique d'interaction pour GestionDesCatalogues.xaml
    /// </summary>
    public partial class GestionDesCatalogues : UserControl
    {
        public GestionDesCatalogues()
        {
            InitializeComponent();
            this.afficheList.Children.Add(new Controlleur.Catalogues.ListCatalogue());
        }
        private void ChercherCatalogue_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Creer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Suprimer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rechercher_Click(object sender, RoutedEventArgs e)
        {
            this.afficheList.Children.Add(new Controlleur.Catalogues.ChercherCatalogue());
        }
    }
}
