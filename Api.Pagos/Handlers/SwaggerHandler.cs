using Api.Pagos.Const;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace Api.Pagos.Handlers
{
    public static class SwaggerHandler
    {
        public static void SwaggerConfig(IServiceCollection service)
        {
            service.AddSwaggerGen(sw =>
            {
                sw.SwaggerDoc(SwaggerConfigConst.DocInfoVersion, new OpenApiInfo
                {
                    Title = SwaggerConfigConst.DocInfoTitle,
                    Version = SwaggerConfigConst.DocInfoVersion
                });

            });
        }

        public static void userSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(sw =>
            {
                sw.SwaggerEndpoint(SwaggerConfigConst.EndPointUrl, SwaggerConfigConst.EndPointDescription);
            });
        }
    }
}
