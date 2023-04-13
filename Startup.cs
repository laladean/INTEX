using INTEX.Data;
using INTEX.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using System.Net;


namespace INTEX
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();



            services.AddRazorPages();

            

            services.AddControllersWithViews();
            services.AddDbContext<intex2Context>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("IntexConnection")));

            services.AddScoped<IIntexRepository, EFIntexRepository>();

            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 14;
                options.Password.RequiredUniqueChars = 9;
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential 
                // cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;

                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdministratorRole",
                     policy => policy.RequireRole("Administrator"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseHsts();
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.Use(async (context, next) =>
            {

                context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'; script-src 'unsafe-inline' 'nonce-rAnd0m' https://localhost:44308/lib/jquery/dist/jquery.min.js https://localhost:44308/lib/bootstrap/dist/js/bootstrap.bundle.min.js https://localhost:44308/js/site.js?v=dLGP40S79Xnx6GqUthRF6NWvjvhQ1nOvdVSwaNcgG18 https://localhost:44308/_framework/aspnetcore-browser-refresh.js https://cdn.jsdelivr.net/gh/bmabey/pyLDAvis@3.4.0/pyLDAvis/js/ldavis.v3.0.0.js https://cdn.bokeh.org/bokeh/release/bokeh-2.4.3.min.js https://localhost:44308/_framework/aspnetcore-browser-refresh.js https://d3js.org/d3.v5.js https://localhost:44308/lib/jquery/dist/jquery.min.js https://localhost:44308/lib/bootstrap/dist/js/bootstrap.bundle.min.js https://localhost:44308/js/site.js?v=dLGP40S79Xnx6GqUthRF6NWvjvhQ1nOvdVSwaNcgG18 https://cdn.jsdelivr.net/gh/bmabey/pyLDAvis@3.4.0/pyLDAvis/js/ldavis.v1.0.0.css https://cdn.bokeh.org/bokeh/release/bokeh-2.4.3.min.js 'sha256-pPykIWxJnaED+2MuvQdw7UmlTMo0F1Xlurq7GWKESSs=' 'sha256-gr1PlpfsuzadkPcwRuGhTlhAhpUw3MdLt+oM4IfdtyU=' 'sha256-+63GG2DRxNxf/70kqHL2bt/xA3tg/0ef107lXBpbpH0=' 'sha256-K7nQYYOKKvJV2g2mTJz790/tCykm3ZEAuiMYzV4I/Sg=' ; style-src 'unsafe-inline' 'unsafe-hashes' https://cdn.jsdelivr.net/gh/bmabey/pyLDAvis@3.4.0/pyLDAvis/js/ldavis.v1.0.0.css 'sha256-47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=' 'sha256-7IUJ0R3PZfMkzNNqi85q9mJpBJO7c1nOmYmrbt22Has=' 'sha256-PE7w0Tsj/GKnZHFyAkLUC8LABP2dUj/jlsURwHPuZRM=' 'sha256-pvTsXv5kUs7+o2/TtrmVcqVIFBmZXmeQl0p15vGrtAo=' 'self'; connect-src wss://localhost:44397/INTEX/ 'self; font-src 'self'; frame-src 'self'");

                await next();
            });

            app.UseEndpoints(endpoints =>
            {

               
                

                endpoints.MapControllerRoute("hairpage",
                    "Burials/{hairColor}/{pageNum?}",
                    new { Controller = "Home", action = "Burials"});


                endpoints.MapControllerRoute("hairagepage",
                    "Burials/{hairColor}/{ageAtDeath}/{burialDepth}/{pageNum?}",
                    new { Controller = "Home", action = "Burials" });


                endpoints.MapControllerRoute("Burials",
                   "Burials",
                   new { Controller = "Home", action = "Burials" });

                endpoints.MapControllerRoute("Paging",
                   "Burials/{pageNum?}",
                   new { Controller = "Home", action = "Burials"});

                


                
                

                




                endpoints.MapDefaultControllerRoute();


                endpoints.MapRazorPages();
            });
        }
    }
}
