//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MUE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int MessageID { get; set; }
        public string text { get; set; }
        public System.DateTime made { get; set; }
        public string ApplicationUserID { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Conversation Conversation { get; set; }
    }
}
