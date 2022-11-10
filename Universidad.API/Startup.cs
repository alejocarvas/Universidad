using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Universidad.Data.UnitOfWork;
using Universidad.Service;
using u = Universidad.Data.UnitOfWork;
using Microsoft.OpenApi.Models;

namespace Universidad.API
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
            services.AddControllers();

            services.AddScoped<IEstudianteService, EstudianteService>();
            services.AddScoped<IMateriaService, MateriaService>();
            services.AddScoped<ISemestreService, SemestreService>();

            // Create a single instance of unit of work
            services.AddSingleton<IUnitOfWork>(op => new u.UnitOfWork(
                Configuration.GetConnectionString("Universidad")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Universidad API",
                    Version = "v1",
                    Description = "Esta API expone los métodos de comunicación con el modelo de una universidad",
                    Contact = new OpenApiContact
                    {
                        Name = "Developer Alejandro Carvajal",
                        Email = "alejocarvas@gmail.com",
                        Url = new Uri("https://github.com/alejocarvas"),
                    },
                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Universidad API V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


    }
}
