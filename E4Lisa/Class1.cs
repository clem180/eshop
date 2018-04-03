using E4Lisa.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4Lisa
{
    public class Class1
    {
        private LISA_DIGITALEntities db = new LISA_DIGITALEntities();
        public List<string> CataloguesListe { get; set; }
        public List<string> entiteListe { get; set; }
        public Class1(){
            List<string> cataloguesListe = new List<string>();
            List<string> entitesListe = new List<string>();
            List<CATALOGUE> catalogues = db.CATALOGUE.ToList();

            foreach (CATALOGUE catalogue in catalogues)
            {
                cataloguesListe.Add(catalogue.Label);
            }
            List<ENTITE> entites = db.ENTITE.ToList();
            foreach (ENTITE entite in entites)
            {
                entitesListe.Add(entite.Name);
            }
            entiteListe = entitesListe;
            CataloguesListe = cataloguesListe;
        }
    }
}
