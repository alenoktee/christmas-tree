using Microsoft.EntityFrameworkCore;

namespace christmas_tree.Models
{
    public class CongratulationContext : DbContext
    {
        public DbSet<Congratulation> Congratulations { get; set; }

        public CongratulationContext(DbContextOptions options) : base(options)
        {

        }
    }
}
