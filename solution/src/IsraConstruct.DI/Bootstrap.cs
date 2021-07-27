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
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(connection));

            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton(typeof(CategoryStorage));
            services.AddSingleton(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}