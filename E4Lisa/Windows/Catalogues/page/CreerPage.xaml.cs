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

namespace E4Lisa.Windows.Catalogues.page
{
    /// <summary>
    /// Logique d'interaction pour CreerPage.xaml
    /// </summary>
    public partial class CreerPage : Window
    {
        private LISA_DIGITALEntities db = new LISA_DIGITALEntities();
        public CreerPage(long ctid)
        {
            InitializeComponent();
            cat_id.Text = ctid.ToString();
        }

        private void creer_Click(object sender, RoutedEventArgs e)
        {

            PAGE CE = new PAGE()
            {
                Number = Int32.Parse(Price.Text.ToString()),
                CAT_Id = Int32.Parse(cat_id.Text.ToString())
                
            };

            db.PAGE.Add(CE);
            db.SaveChanges();
            this.Close();
        }
    }
}
