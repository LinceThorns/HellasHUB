using HellasAPIs.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HellasAPIs.Server.Models
{
    public class HellasDbContext:DbContext
    {
        public HellasDbContext(DbContextOptions<HellasDbContext> options):base(options)
        {
        }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Money> Monies { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OwnedItem> OwnedItems { get; set; }
    }
}
