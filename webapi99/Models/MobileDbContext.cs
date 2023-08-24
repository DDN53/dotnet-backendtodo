using Microsoft.EntityFrameworkCore;

namespace webapi99.Models
{
    public class MobileDbContext : DbContext
    {
        public MobileDbContext(DbContextOptions<MobileDbContext> options) : base(options)
        {
        }
        public DbSet<Mobile> Mobiles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ddn;User Id=Dinuka;password=1234;TrustServerCertificate = True");
        }
    }
}
