using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Todolist.Models
{
    public class TodolistDbContext : DbContext
    {
        public TodolistDbContext (DbContextOptions<TodolistDbContext> options)
            : base(options)
        {
        }

        public DbSet<Todolist.Models.Item> Items { get; set; }
    }
}
