using System;
using Microsoft.Extensions.DependencyInjection;
using IsraConstruct.data;
using Microsoft.EntityFrameworkCore;
using IsraConstruct.domain;
using IsraConstruct.domain.Products;

namespace IsraConstruct.DI
{
    public class Bootstrap{
        public static void Configure(IServiceCollection services, string connection){
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(CategoryStorage));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(connection));
        }
    }
}