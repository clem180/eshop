//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E4Lisa.BDD
{
    using System;
    using System.Collections.Generic;
    
    public partial class CATALOGUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATALOGUE()
        {
            this.CATALOGUE_ENTITE = new HashSet<CATALOGUE_ENTITE>();
            this.PAGE = new HashSet<PAGE>();
        }
    
        public long Id { get; set; }
        public string Type { get; set; }
        public string Label { get; set; }
        public string Speed { get; set; }
        public long CatalogWidth { get; set; }
        public long CatalogHeight { get; set; }
        public long OPE_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATALOGUE_ENTITE> CATALOGUE_ENTITE { get; set; }
        public virtual OPERATION OPERATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGE> PAGE { get; set; }
    }
}
