using Microsoft.EntityFrameworkCore;

namespace Mission10_Creer.Data
{
    public class BowlerDbContext : DbContext
    {
        public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options) { }
        
        public DbSet<BowlerInfo> Bowlers { get; set; }
        public DbSet<TeamInfo> Teams { get; set; }
    }
}