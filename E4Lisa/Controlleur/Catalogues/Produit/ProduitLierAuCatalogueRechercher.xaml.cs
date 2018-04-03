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

namespace E4Lisa.Controlleur.Catalogues.Produti
{
    /// <summary>
    /// Logique d'interaction pour ProduitLierAuCatalogueRechercher.xaml
    /// </summary>
    public partial class ProduitLierAuCatalogueRechercher : UserControl
    {
        private LISA_DIGITALEntities db = new LISA_DIGITALEntities();
        public ProduitLierAuCatalogueRechercher(long NomDuCatalogue)
        {
            InitializeComponent();
            List<PAGE> pages = db.PAGE.Where(x => x.CAT_Id == NomDuCatalogue).ToList();
           
            foreach (PAGE page in pages)
            {
                List<ZONE> zones = db.ZONE.Where(x => x.PAG_Id == page.Id).ToList();
                
                foreach (ZONE zone in zones)
                {
                    
                    this.DataContext = ((App)App.Current).entity.PRODUIT.Where(x => x.Id == zone.PRO_Id).ToList();
                }
            }
           
        }
    }
}
