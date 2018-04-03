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

namespace E4Lisa.Windows.Catalogues.Section
{
    /// <summary>
    /// Logique d'interaction pour CreerUneSection.xaml
    /// </summary>
    public partial class CreerUneSection : Window
    {

        private LISA_DIGITALEntities db = new LISA_DIGITALEntities();
        public CreerUneSection(long idProd, long idpage)
        {
            InitializeComponent();
            prod.Text = idProd.ToString();
            page.Text = idpage.ToString();
        }

        private void creer_Click(object sender, RoutedEventArgs e)
        {
            ZONE CE = new ZONE()
            {
                CooX = Int32.Parse(COOX.Text.ToString()),
                CooY = Int32.Parse(COOY.Text.ToString()),
                Height = Int32.Parse(heightZone.Text.ToString()),
                Width = Int32.Parse(WidhtZone.Text.ToString()),
                PRO_Id = Int32.Parse(prod.Text.ToString()),
                PAG_Id = Int32.Parse(page.Text.ToString())
            };

            db.ZONE.Add(CE);
            db.SaveChanges();
            this.Close();
        }
    }
}
