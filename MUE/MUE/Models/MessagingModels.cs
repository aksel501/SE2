using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MUE.Models
{
    public class Message
    {
        public string MessageID { get; set; }

        public string text { get; set; }
        public DateTime made { get; set; }

        [ForeignKey("MessageID")]
        public ApplicationUser ApplicationUser { get; set; }

        public Conversation Conversation { get; set; }

    }

    public class Conversation
    {
        [Key]
        public int ConversationID { get; set; }

        public DateTime LastSeen { get; set; }
        public DateTime Started { get; set; }
        public string subject { get; set; }

        public string ApplicationUserID { get; set; }

        public string MessageID { get; set; }

        [ForeignKey("MessageID")]
        public ICollection<Message> Message { get; set; }

        [ForeignKey("ApplicationUserID")]
        public ICollection<ApplicationUser> ApplicationUser { get; set; }



    }
}