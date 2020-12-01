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
        public DbSet<Item> Items { get; set; }
        public DbSet<OwnedItem> OwnedItems { get; set; }
        public DbSet<Origin> Origins { get; set; }
        public DbSet<CharRole> CharRoles { get; set; }
        public DbSet<OwnedRoles> OwnedRoles { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
