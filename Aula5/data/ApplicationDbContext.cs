using Microsoft.EntityFrameworkCore;
using dominio.Entities;

namespace data {
    public class ApplicationDbContext : DbContext{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {    
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<User> User { get; set; }

        public DbSet<Departamento> Departamento { get; set; }

    }
}
