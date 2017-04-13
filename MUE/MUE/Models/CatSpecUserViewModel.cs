using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUE.Models
{
    public class CatSpecUserViewModel
    {
        AspNetUser AspNetUser { get; set; }
        CATAGORY Catagory { get; set; }
        SPECIALTY Specialty { get; set; }

        public CatSpecUserViewModel (AspNetUser aspnetuser, CATAGORY catagory, SPECIALTY specialty)
        {
            AspNetUser = aspnetuser;
            Catagory = catagory;
            Specialty = specialty;


        }
    }
}
