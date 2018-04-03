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

namespace E4Lisa.Controlleur.Catalogues.pages
{
    /// <summary>
    /// Logique d'interaction pour ListPages.xaml
    /// </summary>
    public partial class ListPages : UserControl
    {
        private LISA_DIGITALEntities db = new LISA_DIGITALEntities();
        public ListPages(long recherche)
        {
            InitializeComponent();
            id_cat.Text = recherche.ToString();
            this.DATA(recherche);
          
        }
       
        public void DATA(long recherche)
        {
            this.DataContext = ((App)App.Current).entity.PAGE.Where(x => x.CAT_Id == recherche).ToList();
        }

        private void AfficherSection_Click(object sender, RoutedEventArgs e)
        {

            try
            {


                if (dataGridElements.SelectedItems.Count == 1)
                {
                    PAGE caten = (PAGE)dataGridElements.SelectedItem;

                    this.ListeSection.Children.Add(new Controlleur.Catalogues.Section.ListSection(caten.Id));

                }
                else
                {
                    MessageBox.Show("Merci de sélectionner un et un élément maximum");
                }

            }
            catch (Exception er)
            {

                throw er;
            }
        }

        public void Supprimer()
        {
            if (dataGridElements.SelectedItems.Count == 1)
            {
                //Faire la modif
                PAGE pageASupprimer = (PAGE)dataGridElements.SelectedItem;
               
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élément ?",
                                    "Suppression",
                                    MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    ((App)App.Current).entity.PAGE.Remove(pageASupprimer);

                    //Sauvegarde
                    ((App)App.Current).entity.SaveChanges();
                    DATA(pageASupprimer.CAT_Id);
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

        public void Modifier()
        {
/*
            try
            {

                if (dataGridElements.SelectedItems.Count == 1)
                {
                    PAGE caten = (PAGE)dataGridElements.SelectedItem;

                    Windows.Acces.ModifierAcces acces = new Windows.Acces.ModifierAcces(caten);

                    acces.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Merci de sélectionner un et un élément maximum");
                }
                
            }
            catch (Exception e)
            {

                throw e;
            }

    */
        }

        private void ModifierPages_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Suprimer_Click(object sender, RoutedEventArgs e)
        {
          
            

            
                Supprimer(); 
                
            
        }

        private long longConvert(int valeur)
        {
            int longInt = 0;
            long intlong = 0;
            while(longInt != valeur){
                longInt++;
                intlong++;
            }
            return intlong;
        }
        private void CreerAcces_Click(object sender, RoutedEventArgs e)
        {
            DATA(Int32.Parse(id_cat.Text.ToString()));
        }
        private void Creer_Click(object sender, RoutedEventArgs e)
        {
            long cid = longConvert(Int32.Parse(id_cat.Text.ToString()));
            PAGE pageASupprimer = (PAGE)dataGridElements.SelectedItem;
            Windows.Catalogues.page.CreerPage CP = new Windows.Catalogues.page.CreerPage(cid);
            CP.Show();
            CP.creer.Click += CreerAcces_Click;
          
            
            
           
        }
    }
}
