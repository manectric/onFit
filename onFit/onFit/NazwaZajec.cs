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
    
    public partial class NazwaZajec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NazwaZajec()
        {
            this.Zajecia = new HashSet<Zajecia>();
        }
    
        public int ID { get; set; }
        public Nullable<int> IDParent { get; set; }
        public string NazwaZajec1 { get; set; }
        public string OpisZajec { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zajecia> Zajecia { get; set; }
    }
}
