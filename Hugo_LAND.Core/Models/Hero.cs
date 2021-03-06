//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hugo_LAND.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hero()
        {
            this.InventaireHeroes = new HashSet<InventaireHero>();
            this.Items = new HashSet<Item>();
        }
    
        public int Id { get; set; }
        public int Niveau { get; set; }
        public long Experience { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int StatStr { get; set; }
        public int StatDex { get; set; }
        public int StatVitalite { get; set; }
        public string NomHero { get; set; }
        public bool EstConnecte { get; set; }
        public int StatReg { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual Classe Classe { get; set; }
        public virtual CompteJoueur CompteJoueur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventaireHero> InventaireHeroes { get; set; }
        public virtual Monde Monde { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
    }
}
