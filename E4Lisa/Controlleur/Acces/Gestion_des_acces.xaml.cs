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

namespace E4Lisa.Controlleur
{
    /// <summary>
    /// Logique d'interaction pour Gestion_des_acces.xaml
    /// </summary>
    public partial class Gestion_des_acces : UserControl
    {
        public Gestion_des_acces()
        {
            InitializeComponent();
            this.afficheList.Children.Add(new Controlleur.Acces.ListAcces());
            
           
        }

        private void Creer_Click(object sender, RoutedEventArgs e)
        {
            Acces.CreerAcces acces = new Acces.CreerAcces();
            this.afficheList.Children.RemoveAt(0);
            this.afficheList.Children.Add(acces);
            acces.creerAcces.Click += CreerAcces_Click;

        }

        private void CreerAcces_Click(object sender, RoutedEventArgs e)
        {
            this.afficheList.Children.Clear();
            this.afficheList.Children.Add(new Controlleur.Acces.ListAcces());
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {

            object moduleCharge = null;
            foreach (var item in this.afficheList.Children)
            {
                moduleCharge = item;
            }

            if (moduleCharge is Controlleur.Acces.ListAcces)
            {
                ((Controlleur.Acces.ListAcces)moduleCharge).Modifier();
            }
        }
        public  void clean()
        {
            this.afficheList.Children.Add(new Controlleur.Acces.ListAcces());
        }
        private void Suprimer_Click(object sender, RoutedEventArgs e)
        {
            object moduleCharge = null;
            foreach (var item in this.afficheList.Children)
            {
                moduleCharge = item;
            }

            if (moduleCharge is Controlleur.Acces.ListAcces)
            {
                ((Controlleur.Acces.ListAcces)moduleCharge).Supprimer();
            }
           
        }
        public void ControleAcharger( )
        {
            
        }
        public void cleancontroller()
        {
            this.afficheList.Children.Clear();
        }
    }
}
