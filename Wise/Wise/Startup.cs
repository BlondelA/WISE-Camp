using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Metier.Data;
using Metier.Services.Interfaces;
using Metier.Services;
using Metier.Repositories.Utilisateur;
using Metier.Repositories;
using Metier.Repositories.Adresse;
using Metier.Repositories.Coordonnees;

namespace Wise
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<BaseDbContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"));
            });
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDistributedMemoryCache();
            services.AddSession();
            var connection = @"Server=10.2.8.224;port=3306;User Id=charly;Password=charly;Database=wisedb;";
            services.AddDbContext<BaseDbContext>(options => options.UseMySql(connection));
            services.AddScoped<IUtilisateurService, UtilisateurService>();
            services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();
            services.AddScoped<ICoordonneesService, CoordonneesService>();
            services.AddScoped<ICoordonneesRepository, CoordonneesRepository>();
            services.AddScoped<IAdresseService, AdresseService>();
            services.AddScoped<IAdresseRepository, AdresseRepository>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Connexion}/{id?}");
            });
        }
    }
}
