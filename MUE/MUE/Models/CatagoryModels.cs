using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MUE.Models
{
    public class Catagory
    {
        public int CatagoryID;
        public string catagoryName;
        public string catagoryDescription;

        
        public ICollection<IsACatagory> IsACatagory;

        public ICollection<TypeOfProject> TypeOfProject;

    }


}
