using Api.Pagos.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Pago.Application.Services.Interface
{
    public interface IProductService
    {
        Task<ResponseModel> CreateProduct(ProductoDto producto);
        Task<List<ProductoDto>> GetProducts();
        Task<ProductoDto> GetProductById(int id);
    }
}
