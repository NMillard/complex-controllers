using System.Collections.Generic;
using ComplexControllers.Application.Interfaces;
using ComplexControllers.Application.Queries;
using ComplexControllers.DataLayer;
using ComplexControllers.DataLayer.Repositories;
using ComplexControllers.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ComplexControllers.CorrectWebClient {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();

            services.AddDbContext<DataStore>(options => options.UseInMemoryDatabase("db"));
            DataStore dataStore = services.BuildServiceProvider().GetRequiredService<DataStore>();
            dataStore.Database.EnsureCreated(); // Just to seed data - do not do this in production!

            services.AddScoped<GetUsers>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}