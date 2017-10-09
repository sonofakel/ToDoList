using System;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class ToDoListContext : DbContext
    {
        public virtual DbSet<Category> Categories 
        {
            get;
            set;
        }
        public virtual DbSet<Item> Items
        {
            get;
            set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;database=todolist;uid=root;pwd=root;port=8889");
        }
    }
}
