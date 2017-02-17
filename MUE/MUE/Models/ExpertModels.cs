using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MUE.Models
{
    public class Expert
    {
        public string ApplicationUserID { get; set; }

        public ApplicationUser ApplicationUser;

        public ICollection<Specialty> Specialty;

        public ICollection<IsACatagory> IsACatagory;
    }

    public class Specialty
    {
        public string nameOfSpecialty;
        public string descriptionOfSpecialty;

        public Expert Expert;
    }

    public class IsACatagory
    {
        public int yearsExperience { get; set; }
        public Expert Expert;
        public Catagory Catagory;
    }
}