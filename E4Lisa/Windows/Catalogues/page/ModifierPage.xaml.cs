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
    /// Logique d'interaction pour ModifierPage.xaml
    /// </summary>
    
    public partial class ModifierPage : Window
    {
        private PAGE pa;
        public ModifierPage(PAGE PA)
        {
            InitializeComponent();
            number.Text = PA.Number.ToString();
            pa = PA;
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            pa.Number = Int32.Parse(number.Text.ToString());
            

            ((App)App.Current).entity.SaveChanges();

            this.DialogResult = true;
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
