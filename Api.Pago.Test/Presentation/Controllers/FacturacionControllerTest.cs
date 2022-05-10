using Api.Pago.Application.Services.Interface;
using Api.Pagos.Controllers;
using Api.Pagos.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Api.Pago.Test.Presentation.Controllers
{
    public class FacturacionControllerTest
    {
        [Fact]
        public void FacturacionController_obtenerPedidos_OK()
        {
            #region Arrange
            var facturacionServiceMock = new Mock<IFacturacionService>();
            facturacionServiceMock.Setup(h => h.GetPedidos())
                .ReturnsAsync(new List<Pedido>());

            var facturacionController = new FacturacionController(facturacionServiceMock.Object);
            #endregion

            #region Act
            var response = facturacionController.obtenerPedidos();
            #endregion

            #region Assert
            Assert.IsType<OkObjectResult>(response.Result);
            #endregion

        }

        [Fact]
        public void FacturacionController_obtenerPedidoId_OK()
        {
            #region Arrange
            var facturacionServiceMock = new Mock<IFacturacionService>();
            facturacionServiceMock.Setup(h => h.GetPedidoById(It.IsAny<int>()))
                .ReturnsAsync(new Pedido());

            var facturacionController = new FacturacionController(facturacionServiceMock.Object);
            #endregion

            #region Act
            var response = facturacionController.obtenerPedidoId(1);
            #endregion

            #region Assert
            Assert.IsType<OkObjectResult>(response.Result);
            #endregion

        }

        [Fact]
        public void FacturacionController_GuardarPedido_OK()
        {
            #region Arrange
            var facturacionServiceMock = new Mock<IFacturacionService>();
            facturacionServiceMock.Setup(h => h.GuardarPedido(It.IsAny<Pedido>()))
                .ReturnsAsync(new ResponseLogistica());

            var facturacionController = new FacturacionController(facturacionServiceMock.Object);
            #endregion

            #region Act
            var response = facturacionController.GuardarPedido(new Pedido());
            #endregion

            #region Assert
            Assert.IsType<OkObjectResult>(response.Result);
            #endregion

        }

        [Fact]
        public void FacturacionController_FacturarPedido_OK()
        {
            #region Arrange
            var facturacionServiceMock = new Mock<IFacturacionService>();
            facturacionServiceMock.Setup(h => h.CalcularPedido(It.IsAny<List<Productos>>()))
                .Returns(new Response());

            var facturacionController = new FacturacionController(facturacionServiceMock.Object);
            #endregion

            #region Act
            var response = facturacionController.FacturarPedido(new List<Productos>());
            #endregion

            #region Assert
            Assert.IsType<OkObjectResult>(response);
            #endregion

        }
    }
}
