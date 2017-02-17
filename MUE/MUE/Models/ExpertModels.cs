using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MUE.Models
{
    public class Expert : ApplicationUser
    {
        public ICollection<Specialty> Specialty;

        public ICollection<IsACatagory> IsACatagory;
    }

    public class Specialty
    {
        public string nameOfSpecialty { get; set; }
        public string descriptionOfSpecialty { get; set; }

        [ForeignKey("Expert")]
        public string ExpertID { get; set; }


        public Expert Expert;
    }

    public class IsACatagory
    {
        public int yearsExperience { get; set; }

        public string ExpertID { get; set; }
        public string CatagoryID { get; set; }

        [ForeignKey("ExpertID")]
        public Expert Expert;

        [ForeignKey("CatagoryID")]
        public Catagory Catagory;
    }

} 