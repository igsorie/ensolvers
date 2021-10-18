using BusinessLogic.Services;
using BusinessLogic.DAO;
using EnsolversDB;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BusinessLogic;
using EnsolversDB.Repositories;
using System;

namespace EnsolversWebApi
{
    public class Startup
    {
        private readonly string _MyCors = "MyCors";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();


            services.AddScoped<IItemRepository, DataAccessItem>();

            services.AddScoped<IItemService, ItemService>();

            services.AddScoped<IFolderRepository, DataAccessFolder>();
            services.AddScoped<IFolderService, FolderService>();

            services.AddDbContext<EnsolversDBContext>(opts =>
            opts.UseSqlServer(Configuration.GetConnectionString("sqlConnection"),
            b => b.MigrationsAssembly("EnsolversWebApi")));

            services.AddCors(options =>
            {
                options.AddPolicy(name: _MyCors, builder =>
                {
                    builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost").AllowAnyHeader().AllowAnyMethod();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(_MyCors);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
