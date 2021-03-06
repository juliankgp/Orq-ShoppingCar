using Api.Pago.Application.Services.Interface;
using Api.Pagos.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Orq.Pagos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturacionController : ControllerBase
    {
        private readonly IFacturacionService _facturacionService;
        public FacturacionController(IFacturacionService facturacionService)
        {
            _facturacionService = facturacionService;
        }

        [HttpGet("ObtenerPedidos")]
        public async Task<IActionResult> ObtenerPedidos()
        {

            var result = await _facturacionService.GetPedidos();
            return Ok(result);
        }

        [HttpGet("ObtenerPedidoId")]
        public async Task<IActionResult> ObtenerPedidoId(int id)
        {
            var result = await _facturacionService.GetPedidoById(id);
            return Ok(result);
        }

        [HttpPost("GuardarPedido")]
        public async Task<IActionResult> GuardarPedido(Pedido pedido)
        {
            var result = await _facturacionService.GuardarPedido(pedido);
            return Ok(result);
        }

        [HttpPost("FacturarPedido")]
        public IActionResult FacturarPedido(List<Productos> pedido)
        {
            var result = _facturacionService.CalcularPedido(pedido);
            return Ok(result);
        }

    }
}
