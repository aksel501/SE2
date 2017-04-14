namespace MUE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROJECT")]
    public partial class PROJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROJECT()
        {
            AspNetUsers = new HashSet<AspNetUser>();
            CATAGORies = new HashSet<CATAGORY>();
        }

        public int ID { get; set; }

        [StringLength(128)]
        public string PROJECTCREATORID { get; set; }

        public bool COMPLETED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATCOMPLETED { get; set; }

        [Required]
        [StringLength(40)]
        public string TITLE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? STARTDATE { get; set; }

        [Required]
        public string DESCRIPTION { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATAGORY> CATAGORies { get; set; }
    }
}
