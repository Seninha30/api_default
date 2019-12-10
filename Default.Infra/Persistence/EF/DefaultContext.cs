using Default.Domain.Entity;
using Default.Domain.ObjectValues;
using Default.Infra.Persistence.MAP;
using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;

namespace Default.Infra.Persistence.EF
{
    public class DefaultContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //todo ajustar a connection string na classe startup
            optionsBuilder.UseSqlServer("server=localhost;database=Default;uid=sa;password=p@ssw0rd;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ignorar classes
            modelBuilder.Ignore<Notification>();
            modelBuilder.Ignore<Nome>();
            modelBuilder.Ignore<Email>();

            modelBuilder.ApplyConfiguration(new UserMap());

            base.OnModelCreating(modelBuilder);

        }
    }
}
