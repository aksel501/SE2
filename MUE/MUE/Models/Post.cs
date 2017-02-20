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
    
    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            this.Replies = new HashSet<Reply>();
            this.Replies1 = new HashSet<Reply>();
        }
    
        public int PostID { get; set; }
        public string subject { get; set; }
        public string text { get; set; }
        public System.DateTime dateTimePosted { get; set; }
        public string ApplicationUserID { get; set; }
        public Nullable<int> Child_ParentID { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Reply Reply { get; set; }
        public virtual Reply Reply1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reply> Replies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reply> Replies1 { get; set; }
    }
}
