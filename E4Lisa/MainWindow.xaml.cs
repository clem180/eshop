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

namespace E4Lisa
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void connexion_Click(object sender, RoutedEventArgs e)
        {
            LISA_DIGITALEntities db = new LISA_DIGITALEntities();

            if ((db.UTILISATEUR.FirstOrDefault(x => x.Identifier == identifiant.Text) != null) && (db.UTILISATEUR.FirstOrDefault(x => x.Password == MotDePass.Password) != null))
            {
                Acceuil accueil = new Acceuil();


                accueil.Show();
                this.Close();
            }
        }
    }
}
