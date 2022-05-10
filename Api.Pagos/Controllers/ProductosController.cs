using Api.Pago.Application.Services.Interface;
using Api.Pagos.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Orq.Pagos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductosController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("CrearProducto")]
        public async Task<IActionResult> CrearProducto(ProductoDto producto)
        {
            var response = await _productService.CreateProduct(producto);
            return Ok(response);
        }

        [HttpGet("ObtenerProductos")]
        public async Task<IActionResult> ObtenerProductos()
        {
            var response = await _productService.GetProducts();
            return Ok(response);
        }

        [HttpGet("ObtenerProductoPorId")]
        public async Task<IActionResult> ObtenerProductoPorId(int id)
        {
            var response = await _productService.GetProductById(id);
            return Ok(response);
        }

    }
}
