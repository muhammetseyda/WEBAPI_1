//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEBAPI_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Unvanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unvanlar()
        {
            this.Calisanlar = new HashSet<Calisanlar>();
        }
    
        public int unvanID { get; set; }
        public string unvanAd { get; set; }
        public string unvanKisaKod { get; set; }
        public string unvanAciklama { get; set; }
        public Nullable<bool> unvanAktifMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calisanlar> Calisanlar { get; set; }
    }
}
