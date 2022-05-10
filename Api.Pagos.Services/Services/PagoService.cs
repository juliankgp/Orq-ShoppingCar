using Api.Pagos.Models.Models;
using Api.Pagos.Services.RestServices;
using Api.Pagos.Services.Services.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Pagos.Services.Services
{
    public class PagoService : IPagoService
    {
        private readonly IRestService _restService;
        private readonly IConfiguration _configuration;

        public PagoService(IRestService restService, IConfiguration configuration)
        {
            _restService = restService;
            _configuration = configuration;
        }

        public async Task<List<Pedido>> GetPedidosI()
        {
            try
            {
                string url = _configuration.GetSection("Service:Facturacion:UrlGetPedidos").Value;
                var values = new Dictionary<string, string>();

                List<Pedido> resultado = await _restService.GetRestService<List<Pedido>>(url, values);

                return resultado;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Pedido> GetPedidosByIdI(int id)
        {
            try
            {
                string url = _configuration.GetSection("Service:Facturacion:UrlGetPedido").Value;
                url = url != null ? $"{url}{id}" : "error url";
                var values = new Dictionary<string, string>();

                Pedido resultado = await _restService.GetRestService<Pedido>(url, values);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public async Task<ResponseLogistica> GuardarPedido(Pedido pedido)
        {
            try
            {
                string url = _configuration.GetSection("Service:Facturacion:UrlSavePed").Value;
                var values = new Dictionary<string, string>();

                ResponseLogistica resultado = await _restService.PostRestService<ResponseLogistica>(url, values, pedido);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
