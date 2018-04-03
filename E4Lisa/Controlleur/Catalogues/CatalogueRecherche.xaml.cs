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

namespace E4Lisa.Controlleur.Catalogues
{
    /// <summary>
    /// Logique d'interaction pour CatalogueRecherche.xaml
    /// </summary>
    public partial class CatalogueRecherche : UserControl
    {
        public CatalogueRecherche(string labelRechercher)
        {
            
            InitializeComponent();
           this.DataContext = ((App)App.Current).entity.CATALOGUE.Where(x => x.Label == labelRechercher).ToList();
        }
       
        public long ReturnData()
        {

            CATALOGUE caten = (CATALOGUE)dataGridElements.SelectedItem;

            return caten.Id;

        }
        public void Supprimer()
        {
            if (dataGridElements.SelectedItems.Count == 1)
            {
                //Faire la modif
                CATALOGUE pageASupprimer = (CATALOGUE)dataGridElements.SelectedItem;

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élément ?",
                                    "Suppression",
                                    MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    ((App)App.Current).entity.CATALOGUE.Remove(pageASupprimer);

                    //Sauvegarde
                    ((App)App.Current).entity.SaveChanges();

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
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
