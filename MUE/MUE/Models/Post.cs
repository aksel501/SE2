//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MUE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class POST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POST()
        {
            this.POSTs = new HashSet<POST>();
        }
    
        public int ID { get; set; }
        public string USERID { get; set; }
        public string SUBJECT { get; set; }
        public string TITLE { get; set; }
        public System.DateTime DATETIMEPOSTED { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST> POSTs { get; set; }
    }
}
