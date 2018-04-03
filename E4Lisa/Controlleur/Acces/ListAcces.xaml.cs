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

namespace E4Lisa.Controlleur.Acces
{
    /// <summary>
    /// Logique d'interaction pour ListAcces.xaml
    /// </summary>
    public partial class ListAcces : UserControl
    {
        LISA_DIGITALEntities db = new LISA_DIGITALEntities();

        public ListAcces()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.RefreshDatas();
        }
        public void RefreshDatas()
        {
            this.DataContext = ((App)App.Current).entity.CATALOGUE_ENTITE.ToList();

        }
        public void Supprimer()
        {
            if (dataGridElements.SelectedItems.Count == 1)
            {
                //Faire la modif
                CATALOGUE_ENTITE civiliteASupprimer = (CATALOGUE_ENTITE)dataGridElements.SelectedItem;

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élément ?",
                                    "Suppression",
                                    MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    ((App)App.Current).entity.CATALOGUE_ENTITE.Remove(civiliteASupprimer);

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
            RefreshDatas();
        }

        public void Modifier()
        {

            try
            {

                if (dataGridElements.SelectedItems.Count == 1)
                {
                    CATALOGUE_ENTITE caten = (CATALOGUE_ENTITE)dataGridElements.SelectedItem;

                    Windows.Acces.ModifierAcces acces = new Windows.Acces.ModifierAcces(caten);

                    acces.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Merci de sélectionner un et un élément maximum");
                }
                RefreshDatas();
            }
            catch (Exception e)
            {

                throw e;
            }


        }
    }
}
