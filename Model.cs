using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace quickchat
//namespace ConsoleApp.SQLite
{
    public class DataContext : DbContext
    {
        public DbSet<Chat> Chats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=chat.db");
        }
    }

    public class Chat
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }

        public string Username { get; set; }

        public System.DateTime SentTime { get; set; }
    }
}