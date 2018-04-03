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

namespace E4Lisa.Windows.Catalogues.Produit
{
    /// <summary>
    /// Logique d'interaction pour CreerUnProduit.xaml
    /// </summary>
    public partial class CreerUnProduit : Window
    {
        private LISA_DIGITALEntities db = new LISA_DIGITALEntities();
        public CreerUnProduit(long idcat)
        {
            InitializeComponent();
            recupvaleur.Text = idcat.ToString();
        }

    

        private void creer_Click_1(object sender, RoutedEventArgs e)
        {
            PRODUIT CE = new PRODUIT()
            {
                Label = Label.Text.ToString(),
                Price = Int32.Parse(Price.Text.ToString()),
                Description = Description.Text.ToString(),
                CAT_Id = 1,
            };

            db.PRODUIT.Add(CE);
            db.SaveChanges();
            Windows.Catalogues.Section.CreerUneSection CP = new Windows.Catalogues.Section.CreerUneSection(CE.Id,Int32.Parse(recupvaleur.Text.ToString()));
            CP.Show();
            this.Close();
        }
    }
}
