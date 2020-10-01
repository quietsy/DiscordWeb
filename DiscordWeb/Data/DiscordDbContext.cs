using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DiscordWeb.Data
{
    public class DiscordDbContext : DbContext
    {
        #region Contructor
        public DiscordDbContext(DbContextOptions<DiscordDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscordEntry>()
                .HasIndex(b => b.ChannelName);
        }

        #region Public properties
        public DbSet<DiscordEntry> DiscordEntries { get; set; }
        #endregion

    }
}
