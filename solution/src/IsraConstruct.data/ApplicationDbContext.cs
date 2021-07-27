using System;
using IsraConstruct.domain.Products;
using Microsoft.EntityFrameworkCore;

namespace IsraConstruct.data
{
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
            
        }

        public DbSet<Category> Categories {get; set;}
    }
}
