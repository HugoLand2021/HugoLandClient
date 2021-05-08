//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hugo_LAND.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.EffetItems = new HashSet<EffetItem>();
            this.InventaireHeroes = new HashSet<InventaireHero>();
        }
    
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public Nullable<int> x { get; set; }
        public Nullable<int> y { get; set; }
        public Nullable<int> ImageId { get; set; }
        public byte[] RowVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EffetItem> EffetItems { get; set; }
        public virtual Hero Hero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventaireHero> InventaireHeroes { get; set; }
        public virtual Monde Monde { get; set; }
    }
}
