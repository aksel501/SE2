namespace MUE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        public int ID { get; set; }

        
        [StringLength(128)]
        public string SenderID { get; set; }
        [StringLength(128)]
        public string RecieverID { get; set; }

        public DateTime DATETIMEMADE { get; set; }

        [DataType(DataType.MultilineText)]
        public string TEXT { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual AspNetUser AspNetUser1 { get; set; }
    }
}
