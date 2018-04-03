using E4Lisa.BDD;
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
using System.Windows.Shapes;

namespace E4Lisa.Windows.Catalogues
{
    /// <summary>
    /// Logique d'interaction pour GestiondescataloguesRechercher.xaml
    /// </summary>
    public partial class GestiondescataloguesRechercher : Window
    {
        private LISA_DIGITALEntities db = new LISA_DIGITALEntities();
        public GestiondescataloguesRechercher(string recherche)
        {
            InitializeComponent();
            this.ListCatalogueRechercher.Children.Add(new Controlleur.Catalogues.CatalogueRecherche(recherche));
           
        }

        private void Creer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Suprimer_Click(object sender, RoutedEventArgs e)
        {
            object moduleCharge = null;
            foreach (var item in this.ListCatalogueRechercher.Children)
            {
                moduleCharge = item;
            }

            if (moduleCharge is Controlleur.Catalogues.CatalogueRecherche)
            {
                ((Controlleur.Catalogues.CatalogueRecherche)moduleCharge).Supprimer();
            }
        }

        private void AficherProduitCatalogue_Click(object sender, RoutedEventArgs e)
        {
            object moduleCharge = null;
            long a = 1;
            foreach (var item in this.afficheList.Children)
            {
                moduleCharge = item;
            }

            if (moduleCharge is Controlleur.Acces.ListAcces)
            {
               a = ((Controlleur.Catalogues.CatalogueRecherche)moduleCharge).ReturnData();
            }


            this.ListProduitCatalogue.Children.Add(new Controlleur.Catalogues.pages.ListPages(a));
        }
    }
}
