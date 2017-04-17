using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MUE.Models
{
    [Table("UserCatagories")]
    public class AddCatagoryViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }

        public int CATAGORYID { get; set; }

        public String USERID { get; set; }



    }

    
}