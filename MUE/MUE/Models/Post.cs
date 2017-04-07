namespace MUE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POST")]
    public partial class POST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POST()
        {
            POST1 = new HashSet<POST>();
        }

        public int ID { get; set; }

        public int? REPLIED_TO_POST_ID { get; set; }

        [Required]
        [StringLength(128)]
        public string USERID { get; set; }

        [Required]
        [StringLength(20)]
        public string SUBJECT { get; set; }

        [Required]
        [StringLength(20)]
        public string TITLE { get; set; }

        public DateTime DATETIMEPOSTED { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST> POST1 { get; set; }

        public virtual POST POST2 { get; set; }
    }
}
