using Chat.Models;

namespace Chat.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Chat.ChatContext.ChatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Chat.ChatContext.ChatContext context)
        {
            context.User.AddOrUpdate(
                i => i.UserId,
                new User() { UserId = 1, UserName = "Gustav", Email = "gustav@gmail.com", Password = "gustav" },
                new User() { UserId = 2, UserName = "Alex", Email = "alex@gmail.com", Password = "alex" }
            );
            context.ChatMessage.AddOrUpdate(
                i => i.ChatMessageId,
                new ChatMessage() { ChatMessageId = 1, Message = "Hej på dig", UserId = 1, TimeStamp = DateTime.Now },
                new ChatMessage() { ChatMessageId = 2, Message = "Tja", UserId = 2, TimeStamp = DateTime.Now },
                new ChatMessage() { ChatMessageId = 3, Message = "Visste du att Alex är bäst?", UserId = 1, TimeStamp = DateTime.Now },
                new ChatMessage() { ChatMessageId = 4, Message = "Ja såklart, är du lite efter eller?", UserId = 2, TimeStamp = DateTime.Now }
            );

        }
    }
}
