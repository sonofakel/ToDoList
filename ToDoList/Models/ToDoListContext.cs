using System;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class ToDoListContext : DbContext
    {
        public DbSet<Item> Items
        {
            get;
            set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql(@"Server=localhost;database=todolist;uid=root;pwd=root;port=8889"); 
    }
}
