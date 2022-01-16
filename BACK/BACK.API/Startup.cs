using BACK.Model.Models;
using BACK.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BACK.API
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
            services.AddDbContext<Context>(opt => opt.UseInMemoryDatabase("LetsCodeKanban"));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var context = app.ApplicationServices.GetService<Context>();
            PopularCardsTeste(context);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private static void PopularCardsTeste(Context context)
        {
            var card1 = new Card
            {
                Id = Guid.NewGuid(),
                Titulo = "Card Teste 1",
                Conteudo = "Este é um card pré-carregado"
            };
            context.Cards.Add(card1);

            var card2 = new Card
            {
                Id = Guid.NewGuid(),
                Titulo = "Card Teste 2",
                Conteudo = "Este é um card pré-carregado"
            };
            context.Cards.Add(card2);


            context.SaveChanges();
        }
    }
}
