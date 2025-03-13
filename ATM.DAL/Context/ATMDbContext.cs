using ATM.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace ATM.DAL.Context
{
    public class ATMDbContext : DbContext
    {
        public ATMDbContext()
        {}

        public ATMDbContext(DbContextOptions<ATMDbContext> options)
            :base(options)
        {}

        public DbSet<ContactMessage> ContactMessage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                var connection = "";
                optionsBuilder.UseSqlServer(connection);    
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContactMessage>(entity => 
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Message).IsRequired();
                entity.Property(e => e.CreatedDate);
            });
        }
    }
}
