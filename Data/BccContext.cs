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
    }
}