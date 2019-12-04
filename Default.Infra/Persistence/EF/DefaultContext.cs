using Default.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Default.Infra.Persistence.EF
{
    public class DefaultContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("connctionString");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
