using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Pago.Application.Services.Interface;
using Api.Pagos.Services.RestServices;
using Api.Pagos.Models.Models;
using Microsoft.Extensions.Configuration;

namespace Api.Pago.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;
        private readonly IRestService _restService;
        private readonly IConfiguration _configuration;

        public ProductService(ILogger<ProductService> logger, IRestService restService, IConfiguration configuration)
        {
            _logger = logger;
            _restService = restService;
            _configuration = configuration;
        }

        public async Task<ResponseModel> CreateProduct(ProductoDto producto)
        {
            try
            {
                string url = _configuration.GetSection("Service:Productos:UrlCreate").Value;
                var values = new Dictionary<string, string>();

                ResponseModel resultado = await _restService.PostRestService<ResponseModel>(url, values, producto);

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<ProductoDto>> GetProducts()
        {
            try
            {
                string url = _configuration.GetSection("Service:Productos:UrlGet").Value;
                var values = new Dictionary<string, string>();

                List<ProductoDto> resultado = await _restService.GetRestService<List<ProductoDto>>(url, values);

                return resultado;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ProductoDto> GetProductById(int id)
        {
            try
            {
                string url = _configuration.GetSection("Service:Productos:UrlGetById").Value;
                var values = new Dictionary<string, string>();
                url = url != null ? $"{url}{id}" : "error url";

                ProductoDto resultado = await _restService.GetRestService<ProductoDto>(url, values);

                return resultado;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
    }
}
