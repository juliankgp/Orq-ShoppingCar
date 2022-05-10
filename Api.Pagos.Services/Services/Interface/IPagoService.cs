using Api.Pagos.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Pagos.Services.Services.Interface
{
    public interface IPagoService
    {
        Task<List<Pedido>> GetPedidosI();
        Task<Pedido> GetPedidosByIdI(int id);
        Task<ResponseLogistica> GuardarPedido(Pedido pedido);
    }
}
