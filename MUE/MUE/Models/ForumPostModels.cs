using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MUE.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string subject { get; set; }
        public string text { get; set; }
        public DateTime dateTimePosted { get; set; }

        public string ApplicationUserID { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<Reply> Reply { get; set; }

        public Reply Child { get; set; }





    }

    public class Reply: Post
    {
        public DateTime whenReplied { get; set; }

        
        public int RepliedPostID { get; set; }

        [ForeignKey("RepliedPostID")]
        public Post RepliedToPost { get; set; }
    }
}