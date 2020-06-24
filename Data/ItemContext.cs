using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KatelleOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace KatelleOnline.Data
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options)
            : base(options) { }
        public ItemContext() { }
        public DbSet<ItemDetails> ItemDetails { get; set; }
    }
}