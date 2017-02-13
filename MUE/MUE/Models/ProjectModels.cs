using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MUE.Models
{
    public class Project
    {
        int ProjectID { get; set; }
        bool completed { get; set; }
        string title { get; set; }
        string description { get; set; }
        DateTime startDate { get; set; }
        DateTime completeDate { get; set; }

        ICollection<TypeOfProject> TypeOfProject { get; set; }
        ICollection<Collaborator> Collaborator { get; set; }
    }

    public class TypeOfProject
    {

        public int CatagoryID { get; set; }

        public int ProjectID { get; set; }

        [ForeignKey("CatagoryID")]
        public Catagory Catagory { get; set; }

        [ForeignKey("ProjectID")]
        public Project Project { get; set; }
    }

    public class Collaborator
    {
        public int ProjectID { get; set; }

        public int ApplicationUserID { get; set; }

        [ForeignKey("ProjectID")]
        public Project Project;

        [ForeignKey("ApplicationUserID")]
        public ApplicationUser ApplicationUser;
    }
}