using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace smartSchool.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(
                c => c.UseMySql(Configuration.GetConnectionString("MySQLConnection"),
                new MySqlServerVersion(new Version(8, 0, 26))));

            services.AddControllers().AddNewtonsoftJson(
                opt => opt.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IRepository, Repository>();

            services.AddVersionedApiExplorer(opt =>
                        {
                            opt.GroupNameFormat = "'v'VVV";
                            opt.SubstituteApiVersionInUrl = true;
                        })
                        .AddApiVersioning(opt =>
                        {
                            opt.DefaultApiVersion = new ApiVersion(1, 0);
                            opt.AssumeDefaultVersionWhenUnspecified = true;
                            opt.ReportApiVersions = true;
                        });

            var apiProviderDescription = services.BuildServiceProvider()
                    .GetService<IApiVersionDescriptionProvider>();

            services.AddSwaggerGen(c =>
            {
                foreach (var i in apiProviderDescription.ApiVersionDescriptions)
                {
                    c.SwaggerDoc(i.GroupName, new OpenApiInfo
                    {
                        Title = "API",
                        Version = i.ApiVersion.ToString(),
                        TermsOfService = new Uri("https://www.google.com"),
                        Description = "Smartschool é o futuro das apis de escola brasileiras",
                        License = new OpenApiLicense
                        {
                            Name = "SmartSchool LTDA",
                            Url = new Uri("https://www.google.com.br")
                        },
                        Contact = new OpenApiContact
                        {
                            Name = "Isra peres",
                            Email = "nao interessa",
                            Url = new Uri("https://www.google.com.pt")
                        }
                    });
                }

                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                c.IncludeXmlComments(xmlCommentsFullPath);
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
         IWebHostEnvironment env,
        IApiVersionDescriptionProvider apiVersionDescriptionProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    foreach (var i in apiVersionDescriptionProvider.ApiVersionDescriptions)
                    {
                        c.SwaggerEndpoint($"/swagger/{i.GroupName}/swagger.json", i.GroupName.ToUpperInvariant());
                        c.RoutePrefix = "";

                    }
                }
                );

            // app.UseHttpsRedirection();

            app.UseRouting();

            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
