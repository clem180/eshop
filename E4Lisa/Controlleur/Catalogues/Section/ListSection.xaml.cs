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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace E4Lisa.Controlleur.Catalogues.Section
{
    /// <summary>
    /// Logique d'interaction pour ListSection.xaml
    /// </summary>
    public partial class ListSection : UserControl
    {
        private LISA_DIGITALEntities db = new LISA_DIGITALEntities();
        public ListSection(long recherche)
        {
            InitializeComponent();
            List<ZONE> zones = db.ZONE.Where(x => x.PAG_Id == recherche).ToList();
            recupvaleur.Text = recherche.ToString();
            foreach (ZONE zone in zones)
            {
                List<PRODUIT> produits = db.PRODUIT.Where(x => x.Id == zone.PRO_Id).ToList();

                foreach (PRODUIT produit in produits)
                {
                    this.DataContext = ((App)App.Current).entity.PRODUIT.Where(x => x.Id == zone.PRO_Id).ToList();
                }
                    
            }
        }

        private void AfficherProduit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Creer_Click(object sender, RoutedEventArgs e)
        {
            
            Windows.Catalogues.Produit.CreerUnProduit CP = new Windows.Catalogues.Produit.CreerUnProduit(Int32.Parse(recupvaleur.Text.ToString()));
            
            CP.Show();
            CP.creer.Click += CreerAcces_Click;
        }
        public void DATA(long recherche)
        {
            this.DataContext = ((App)App.Current).entity.PRODUIT.Where(x => x.Id == recherche).ToList();
        }

        private void CreerAcces_Click(object sender, RoutedEventArgs e)
        {
            DATA(Int32.Parse(recupvaleur.Text.ToString()));
        }

        private void Suprimer_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridElements.SelectedItems.Count == 1)
            {
                //Faire la modif
                PRODUIT produitASupprimer = (PRODUIT)dataGridElements.SelectedItem;

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élément ?",
                                    "Suppression",
                                    MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    ((App)App.Current).entity.PRODUIT.Remove(produitASupprimer);

                    //Sauvegarde
                    ((App)App.Current).entity.SaveChanges();
                    DATA(Int32.Parse(recupvaleur.Text.ToString()));
                }
                else
                {
                    //On rafraichit l'entity pour éviter les erreurs de données "fantomes" mal déliées
                    ((App)App.Current).entity = new LISA_DIGITALEntities();
                }
            }
            else
            {
                MessageBox.Show("Merci de sélectionner un et un élément maximum");
            }
        }
    }
}
