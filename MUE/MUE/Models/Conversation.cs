namespace MUE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONVERSATION")]
    public partial class CONVERSATION
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public DateTime? LASTSEEN { get; set; }

        public DateTime? STARTED { get; set; }

        [StringLength(128)]
        public string SUBJECT { get; set; }

        [StringLength(128)]
        public string USERIDs { get; set; }

        public int? MessageIDs { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Message Message { get; set; }
    }
}
