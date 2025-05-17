using Microsoft.EntityFrameworkCore;

namespace Govinet_Front_End_Connection_Checker.Models
{
    public class CheckDbContext:DbContext

    {
        public CheckDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Check>Chekers { get; set; }
    }
}
