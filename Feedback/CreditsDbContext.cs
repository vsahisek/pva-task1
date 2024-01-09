using Microsoft.EntityFrameworkCore;

namespace Feedback
{
    public class CreditsDbContext : DbContext
    {
        public DbSet<Credits> Credits { get; set; }

        public CreditsDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
