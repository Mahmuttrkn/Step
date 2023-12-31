using BusinessLayer.Container;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DTOLayer.DTOS.AppUserDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProjeX.CQRS.Heandlers;
using ProjeX.CQRS.Heandlers.DestinationHeandler;
using ProjeX.Models;
using System.IO;

namespace ProjeX
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
            services.AddLogging(x =>
            {
                x.ClearProviders();
                x.SetMinimumLevel(LogLevel.Debug);
                x.AddDebug();
            });

            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>();
            services.AddControllersWithViews();
            services.AddControllersWithViews().AddFluentValidation();

            services.AddHttpClient();

            services.ContainerDependencies();
            services.AddAutoMapper(typeof(Startup));
            services.CustomValidator();
            services.AddTransient<IValidator<AppUserRegisterDTO>, AppUserRegisterValidatior > ();
            
            services.AddScoped<GetAllDestinationQueryHeandler>();
            services.AddScoped<GetDestinationByIDHeandler>();
            services.AddScoped<CreateDestinationHeandler>();
            services.AddScoped<RemoveDestinationCommandHeandler>();
            services.AddScoped<UpdateDestinationHeandler>();

            services.AddMediatR(typeof(Startup));

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
            });

            services.AddMvc();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath="/Login/SignIn/";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            var path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{ path }\\Logs\\Log1.txt");
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
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404","?code={0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

        }
    }
}
