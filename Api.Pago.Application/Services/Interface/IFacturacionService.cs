using Api.Pagos.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Pago.Application.Services.Interface
{
    public interface IFacturacionService
    {
        Task<List<Pedido>> GetPedidos();
        Task<ResponseLogistica> GuardarPedido(Pedido pedido);
        Task<Pedido> GetPedidoById(int id);
        Response CalcularPedido(List<Productos> ped);


    }
}
