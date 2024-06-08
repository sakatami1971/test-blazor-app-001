using Microsoft.EntityFrameworkCore;
using Data;

namespace Controller
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}
        public DbSet<DGMJYP> DGMJYP { get; set; }
        public DbSet<KYJY2P> KYJY2P { get; set; }
    }
}
