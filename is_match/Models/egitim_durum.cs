//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace is_match.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class egitim_durum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public egitim_durum()
        {
            this.bireysel_uyelik = new HashSet<bireysel_uyelik>();
        }
    
        public int id { get; set; }
        public string egitim_adi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bireysel_uyelik> bireysel_uyelik { get; set; }
    }
}