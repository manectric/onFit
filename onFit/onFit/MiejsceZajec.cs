//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onFit
{
    using System;
    using System.Collections.Generic;
    
    public partial class MiejsceZajec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MiejsceZajec()
        {
            this.Zajecia = new HashSet<Zajecia>();
        }
    
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public string Strona_WWW { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zajecia> Zajecia { get; set; }
    }
}