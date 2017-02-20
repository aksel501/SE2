using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
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

        //public ICollection<Reply> Reply { get; set; }

        //public Reply Child { get; set; }





    }

    //public class Reply : Post
    //{
    //    public DateTime whenReplied { get; set; }


    //    [ForeignKey("Post")]
    //    public int RepliedToPostID { get; set; }


    //    public Post Post { get; set; }
    //}

    //public class InheritanceMappingContext : DbContext
    //{
    //    public DbSet<Post> Post { get; set; }
    //}

    //public class ReplyDBContext : DbContext
    //{

    //    public static ReplyDBContext Create()
    //    {
    //        return new ReplyDBContext();
    //    }

    //    public DbSet<Reply> Reply { get; set; }
    //}

    //public class PostDBContext : DbContext
    //{

    //    public static PostDBContext Create()
    //    {
    //        return new PostDBContext();
    //    }

    //    public DbSet<Post> Post { get; set; }
    //}
}