namespace MUE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatSpecUserViewModel
    {
        public string Id { get; set; }

        [StringLength(128)]
        public string AspNetUser_Id { get; set; }

        public int? Catagory_ID { get; set; }

        public int? Specialty_ID { get; set; }

        [StringLength(64)]
        public string Specialty_NAME { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual CATAGORY CATAGORY { get; set; }

        public virtual SPECIALTY SPECIALTY { get; set; }
    }
}
