using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;


namespace aula2
{
    class Program{
        static void Main(string[] args){
            var host = WebHost
                .CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }

    internal class Startup{
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration){
            _configuration = configuration;
        }

        public void Configure(IApplicationBuilder app){
            String ordem = String.Empty;

            app.Use(async (context, next) => {
                ordem += "1";

                await next.Invoke();

                ordem += "4";

                await context.Response.WriteAsync($"Ordem: {ordem}");
            });

            app.Use(async (context, next) => {
                ordem += "2";

                await next.Invoke();

                ordem += "3";

                await context.Response.WriteAsync("Fala meu bom! ");
            });
        }
    }
}
