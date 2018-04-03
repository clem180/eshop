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

namespace E4Lisa.Windows
{
    /// <summary>
    /// Logique d'interaction pour Acceuil.xaml
    /// </summary>
    public partial class Acceuil : Window
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void Acces_Click(object sender, RoutedEventArgs e)
        {
            this.afficheList.Children.Add(new Controlleur.Gestion_des_acces());
        }

        private void Catalogue_Click(object sender, RoutedEventArgs e)
        {
            this.afficheList.Children.Add(new Controlleur.Catalogues.GestionDesCatalogues());
        }

        private void Produit_Click(object sender, RoutedEventArgs e)
        {

        }
        public void AfficherCreerList()
        {
            this.afficheList.Children.Add(new Controlleur.Acces.CreerAcces());
        }
    }
}
