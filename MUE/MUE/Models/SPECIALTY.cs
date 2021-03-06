namespace MUE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPECIALTY")]
    public partial class SPECIALTY
    {
        [Required]
        [StringLength(128)]
        public string expertID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        [Display(Name = "Specialty")]
        public string NAME { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string DESCRIPTION { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }
}
