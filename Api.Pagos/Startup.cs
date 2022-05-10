using Api.Pagos.Const;
using Api.Pagos.Handlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Configuration;

namespace Api.Pagos
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    p => p
                        .AllowAnyMethod()
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        );
            });

            services.AddMemoryCache();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddDistributedMemoryCache();

            services.AddHttpClient("SsslPolicy");

            SwaggerHandler.SwaggerConfig(services);
            DependencyInjectionHandler.DependencyInjectionConfig(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            SwaggerHandler.userSwagger(app);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //Habilitar swagger
                app.UseSwagger();

                //indica la ruta para generar la configuración de swagger
                app.UseSwaggerUI(sw =>
                {
                    sw.SwaggerEndpoint(SwaggerConfigConst.EndPointUrl, SwaggerConfigConst.EndPointDescription);
                });
            }

            app.UseCors("CorsPolicy");

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
