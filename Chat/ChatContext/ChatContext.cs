using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Chat.Models;

namespace Chat.ChatContext
{
    public class ChatContext : DbContext
    {
        public ChatContext() : base("name=DbConnectionString")
        {
            
        }

        public DbSet<User> User { get; set; }
        public DbSet<ChatMessage> ChatMessage { get; set; }
    }
}