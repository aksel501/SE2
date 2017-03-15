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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        [Display(Name ="Name of Specialty")]
        public string NAME { get; set; }

        [Required]
        [Display(Name = "Description of Specialty")]
        public string DESCRIPTION { get; set; }

        public virtual EXPERT EXPERT { get; set; }
    }
}
