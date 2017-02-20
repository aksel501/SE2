using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MUE.Models;

namespace MUE.Models
{
    public class AccountRegisterViewModel
    {

        //public RegisterViewModel Email { get; set; }

        //public RegisterViewModel Password { get; set; }
        //[Display(Name = "confirm password")]
        //public RegisterViewModel ConfirmPassword { get; set; }

        //[Display(Name = "first name")]
        //public ApplicationUser FirstName { get; set; }
        //[Display(Name = "last name")]
        //public ApplicationUser LastName { get; set; }
        //[Display(Name = "middle initial")]
        //[MaxLength(length:1)]
        //public ApplicationUser MiddleInt { get; set; }
        //[Display(Name = "name of specialty")]
        //public Specialty NameOfSpecialty { get; set; }
        //[Display(Name = "description of specialty")]
        //public Specialty DescriptionOfSpecialty { get; set; }

        //public Expert Specialty { get; set; }

        //public Expert IsaCatagory { get; set; }

        public String Email { get; set; }

        public String Password { get; set; }
        [Display(Name = "Confirm Password")]
        public String ConfirmPassword { get; set; }

        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
        [Display(Name = "Middle Initial")]
        [MaxLength(length: 1)]
        public Char MiddleInt { get; set; }
        [Display(Name = "Name of Specialty")]
        public String NameOfSpecialty { get; set; }
        [Display(Name = "Description of Specialty")]
        public String DescriptionOfSpecialty { get; set; }

        public ICollection<Specialty> Specialty { get; set; }

        public ICollection<IsACatagory> IsACatagory { get; set; }

        
        [Display(Name = "Are you a robot?")]
        public bool isARobot { get; set; }


    }
}