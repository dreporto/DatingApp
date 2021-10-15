using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        // -- properties --
        public DbSet<AppUser> Users { get; set; } 

        // -- constructors --
        public DataContext(DbContextOptions options) : base(options)
        { 
        }
    }
}