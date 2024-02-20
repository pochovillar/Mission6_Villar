using Microsoft.EntityFrameworkCore;

namespace Mission6_Villar.Models
{
    public class MovieDatabaseContext : DbContext
    {
        public MovieDatabaseContext(DbContextOptions<MovieDatabaseContext > options): base (options) //constructor
        {}
        public DbSet<Application> Applications { get; set; }
    }
}
