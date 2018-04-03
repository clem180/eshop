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
    /// Logique d'interaction pour ListCatalogue.xaml
    /// </summary>
    public partial class ListCatalogue : UserControl
    {
        public ListCatalogue()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.RefreshDatas();
        }
        public void RefreshDatas()
        {

            this.DataContext = ((App)App.Current).entity.CATALOGUE.ToList();
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void AfficherPages_Click(object sender, RoutedEventArgs e)
        {
            

                CATALOGUE caten = (CATALOGUE)dataGridElements.SelectedItem;

              long a = caten.Id;

            


            this.ListPages.Children.Add(new Controlleur.Catalogues.pages.ListPages(a));
        }
    }
}
