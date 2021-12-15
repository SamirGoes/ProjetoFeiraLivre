using Microsoft.EntityFrameworkCore;
using FeiraLivre.Api.Models;

namespace FeiraLivre.Api.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<Feira> Feira { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feira>().HasKey(k => k.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
    
}