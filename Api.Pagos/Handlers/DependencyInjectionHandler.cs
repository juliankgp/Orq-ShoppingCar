using Api.Pago.Application.Services;
using Api.Pago.Application.Services.Interface;
using Api.Pagos.Services.RestServices;
using Api.Pagos.Services.Services;
using Api.Pagos.Services.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Pagos.Handlers
{
    public static class DependencyInjectionHandler
    {
        public static void DependencyInjectionConfig(IServiceCollection services)
        {
            services.AddTransient<IPagoService, PagoService>();
            services.AddTransient<IFacturacionService, FacturacionService>();
            services.AddTransient<IRestService, RestService>();
        }

    }
}
