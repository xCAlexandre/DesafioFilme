using Microsoft.EntityFrameworkCore;
using Bcc.Models;

namespace Bcc.Data
{
    public class BccContext : DbContext
    {
        public BccContext (DbContextOptions<BccContext>options) : base(options)
        {
        }

        public DbSet<Movie> Movie {get; set;}
        public DbSet<Actor> Actor {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Actor>().HasKey(x => new { x.Id });

            modelBuilder.Entity<Movie>().HasKey(x => new { x.Id });

            modelBuilder.Entity<Movie>()
        .HasMany(x => x.Actor)
        .WithOne(y => y.Movie);

        }
    }
}