using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chat.Models
{
    public class ChatMessage
    {
        public int ChatMessageId { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}