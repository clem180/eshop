using E4Lisa.BDD;
using E4Lisa.Windows;
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
    /// Logique d'interaction pour CreerAcces.xaml
    /// </summary>
    public partial class CreerAcces : UserControl
    {
        public CreerAcces()
        {
        InitializeComponent();
        DataContext = new Class1();
         



        }
        private LISA_DIGITALEntities db = new LISA_DIGITALEntities();
     
       
        private void creerAcces_Click(object sender, RoutedEventArgs e)
        {
            long test1 = 1;
            long test = 1;
            List<CATALOGUE> catalogues = db.CATALOGUE.Where(x => x.Label == ListeCatalogue.Text).ToList();
            foreach (CATALOGUE catalogue in catalogues)
            {
                test = catalogue.Id;
            }

            List<ENTITE> entites = db.ENTITE.Where(x => x.Name == ListeEntite.Text).ToList();
            foreach (ENTITE entite in entites)
            {
                test1 = entite.Id;
            }
            CATALOGUE_ENTITE CE = new CATALOGUE_ENTITE()
            {
                CAT_Id = test,
                ENT_Id = test1,
                StartDate = Start_Date.DisplayDate,
                DisplayStartDate = Display_StartSate.DisplayDate,
                DisplayEndDate = Display_EndDate.DisplayDate

            };
            
            db.CATALOGUE_ENTITE.Add(CE);
            db.SaveChanges();
            



        }

        private void ComboBox_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
