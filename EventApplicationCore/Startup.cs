using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyAccountProject.Filters;
using MyAccountProject.Model;
using Rotativa.AspNetCore;
using System;

namespace MyAccountProject
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var manager = new ApplicationPartManager();
            manager.ApplicationParts.Add(new AssemblyPart(typeof(Startup).Assembly));

            services.AddSingleton(manager);

            // Add framework services.
            services.AddMvc(options =>
            {
                options.Filters.Add(new CustomExceptionFilterAttribute());
                options.ReturnHttpNotAcceptable = true;
                // options.OutputFormatters = xml
            })
            .AddJsonOptions(options =>
            {
                //For Maintaining Json Format
                options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            });

            // For FileUpload
            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue; // In case of multipart
                x.ValueLengthLimit = int.MaxValue; //not recommended value
                x.MemoryBufferThreshold = Int32.MaxValue;
            });

            // For Setting Session Timeout
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
#pragma warning disable CS0618 // Type or member is obsolete
                options.CookieName = ".EventCore";
#pragma warning restore CS0618 // Type or member is obsolete
            });

            //Getting Connection String From Database
            var connection = Configuration.GetConnectionString("DatabaseConnection");

            services.AddDbContext<DatabaseContext>(options => options.UseMySql(Configuration.GetConnectionString("DatabaseConnection")));

            // UseRowNumberForPaging for Using Skip and Take in .Net Core
            //services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connection, b => b.UseRowNumberForPaging()));

            //services.AddTransient<IRegistration, RegistrationConcrete>();
            //services.AddTransient<ICountry, CountryConcrete>();
            //services.AddTransient<IState, StateConcrete>();
            //services.AddTransient<ICity, CityConcrete>();
            //services.AddTransient<IRoles, RolesConcrete>();
            //services.AddTransient<ILogin, LoginConcrete>();
            //services.AddTransient<IVenue, VenueConcrete>();
            //services.AddTransient<IEquipment, EquipmentConcrete>();
            //services.AddTransient<IFood, FoodConcrete>();
            //services.AddTransient<IDishtypes, DishtypesConcrete>();
            //services.AddTransient<ILight, LightConcrete>();
            //services.AddTransient<IFlower, FlowerConcrete>();
            //services.AddTransient<IBookingVenue, BookingVenueConcrete>();
            //services.AddTransient<IEvent, EventConcrete>();
            //services.AddTransient<IBookEquipment, BookEquipmentConcrete>();
            //services.AddTransient<IBookFood, BookFoodConcrete>();
            //services.AddTransient<IBookFlower, BookFlowerConcrete>();
            //services.AddTransient<IBookingLight, BookingLightConcrete>();
            //services.AddTransient<ITotalbilling, TotalbillingConcrete>();

            //services.AddTransient<ICategory, CategoryConcrete>();
            //services.AddTransient<IUnit, UnitConcrete>();
            //services.AddTransient<IGroup, GroupConcrete>();
            //services.AddTransient<ISubGroup, SubGroupConcrete>();
            //services.AddTransient<IItemMaster, ItemMasterConcrete>();
            //services.AddTransient<IMenuMaster, MenuMasterConcrete>();
            //services.AddTransient<ISettings, SettingsConcrete>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseBrowserLink();
                //app.UseExceptionHandler("/Error");
            }
            else
            {
                app.UseDeveloperExceptionPage();
                //app.UseExceptionHandler("/Error");
            }

            // Using Static Files
            app.UseStaticFiles();
            // Enabling Session
            app.UseSession();
            // Routing
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=SalesBill}/{action=Create}/{id?}");
            });

            //RotativaConfiguration.Setup(env);
            RotativaConfiguration.Setup(env);
        }
    }
}