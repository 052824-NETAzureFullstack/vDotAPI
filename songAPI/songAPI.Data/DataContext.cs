using Microsoft.EntityFrameworkCore;
using songAPI.Models;

namespace songAPI.Data
{
    public class DataContext : DbContext
    {
        // Fields
        public DbSet<Title> Titles => Set<Title>();
        public DbSet<Artist> Artists => Set<Artist>();
        public DbSet<Album> Albums => Set<Album>();

        // Constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        // Methods

    }
}