using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todolist.Models;

namespace Todolist.Models
{
    public class ItemlistDbContext : DbContext
    {
        public ItemlistDbContext (DbContextOptions<ItemlistDbContext> options)
            : base(options)
        {
        }

        public DbSet<Todolist.Models.Itemlist> Itemlist { get; set; }

        public DbSet<Todolist.Models.Item> Item { get; set; }
    }
}
