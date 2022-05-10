using Api.Pago.Application.Services.Interface;
using Api.Pagos.Models.Models;
using Api.Pagos.Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Pago.Application.Services
{
    public class FacturacionService : IFacturacionService
    {
        private readonly IPagoService _pagoService;

        public FacturacionService(IPagoService pagoService)
        {
            _pagoService = pagoService;
        }

        public async Task<List<Pedido>> GetPedidos()
        {
            List<Pedido> resultado = await _pagoService.GetPedidosI();
            return resultado;
        }

        public async Task<Pedido> GetPedidoById(int id)
        {
            Pedido resultado = new Pedido();
            resultado = await _pagoService.GetPedidosByIdI(id);

            return resultado;
        }
        public async Task<ResponseLogistica> GuardarPedido(Pedido pedido)
        {
            ResponseLogistica result = new ResponseLogistica();            
            result = await _pagoService.GuardarPedido(pedido);

            return result;
        }

        public Response CalcularPedido(List<Productos> ped)
        {
            Response result = new Response();

            var subtotal = 0;
            var cantProd = 0;
            var totalImpuestos = 0.0;
            var imp = 0.19;
            if (ped is null)
            {
                throw new Exception("Error modelo nulo");
            }
            else
            {
                foreach (var item in ped)
                {
                    subtotal += Convert.ToInt32(item.Precio) * item.Cantidad;
                    cantProd += item.Cantidad;
                }
            }

            totalImpuestos = subtotal * imp;

            var response = new Result()
            {
                Impuesto = totalImpuestos,
                Subtotal = subtotal,
                Total = subtotal + totalImpuestos
            };

            result.Exitoso = true;
            result.Code = 200;
            result.Data = response;

            return result;
        }


    }
}
