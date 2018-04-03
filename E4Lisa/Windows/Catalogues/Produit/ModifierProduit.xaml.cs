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
    /// Logique d'interaction pour ModifierProduit.xaml
    /// </summary>
    public partial class ModifierProduit : Window
    {
        private PRODUIT PR;
        public ModifierProduit(PRODUIT pr)
        {
            InitializeComponent();
            PR = pr;
            Label.Text = pr.Label.ToString();
            Price.Text = pr.Price.ToString();
            Description.Text = pr.Description.ToString();
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            PR.Label = Label.Text.ToString();
            PR.Price = Int32.Parse(Price.Text.ToString());
            PR.Description = Description.Text.ToString();


            ((App)App.Current).entity.SaveChanges();

            this.DialogResult = true;
            this.Close();
        }
    }
}
