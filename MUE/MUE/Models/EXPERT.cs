namespace MUE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EXPERT")]
    public partial class EXPERT
    {
        public string ID { get; set; }

        [Required]
        [StringLength(128)]
        public string PARENTID { get; set; }

        public bool? VALIDATED { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }
}
