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

namespace E4Lisa.Windows.Acces
{
    /// <summary>
    /// Logique d'interaction pour ModifierAcces.xaml
    /// </summary>
    public partial class ModifierAcces : Window
    {
        private CATALOGUE_ENTITE Caten;
        public ModifierAcces(CATALOGUE_ENTITE catEn)
        {
            InitializeComponent();
            Start_Date.SelectedDate = catEn.StartDate.Date;
            Display_StartSate.SelectedDate = catEn.DisplayStartDate.Date;
            Display_EndDate.SelectedDate = catEn.DisplayEndDate.Date;
            Caten = catEn;
        }

        private void ModifierAcces_Click(object sender, RoutedEventArgs e)
        {
            Caten.StartDate = Start_Date.SelectedDate.Value.Date;
            Caten.DisplayStartDate = Display_StartSate.SelectedDate.Value.Date;
            Caten.DisplayEndDate = Display_EndDate.SelectedDate.Value.Date;

            ((App)App.Current).entity.SaveChanges();

            this.DialogResult = true;
            this.Close();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
