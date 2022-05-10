using Api.Pago.Application.Services;
using Api.Pagos.Models.Models;
using Api.Pagos.Services.Services.Interface;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Api.Pago.Test.Application.Services
{
    public class FacturacionServiceTest
    {

        [Fact]
        public void FacturacionService_GetPedidos_OK()
        {
            #region Arrange
            var pagoServiceMock = new Mock<IPagoService>();
            pagoServiceMock.Setup(m => m.GetPedidosI())
                .ReturnsAsync(new List<Pedido>());

            FacturacionService facturacionService = new FacturacionService(pagoServiceMock.Object);
            #endregion

            #region Act
            var response = facturacionService.GetPedidos();
            #endregion

            #region Assert
            Assert.IsType<List<Pedido>>(response.Result);
            #endregion
        }

        [Fact]
        public void FacturacionService_GetPedidoById_OK()
        {
            #region Arrange
            var pagoServiceMock = new Mock<IPagoService>();
            pagoServiceMock.Setup(m => m.GetPedidosByIdI(It.IsAny<int>()))
                .ReturnsAsync(new Pedido());

            FacturacionService facturacionService = new FacturacionService(pagoServiceMock.Object);
            #endregion

            #region Act
            var response = facturacionService.GetPedidoById(5);
            #endregion

            #region Assert
            Assert.IsType<Pedido>(response.Result);
            #endregion
        }

        [Fact]
        public void FacturacionService_GuardarPedido_OK()
        {
            #region Arrange
            var pagoServiceMock = new Mock<IPagoService>();
            pagoServiceMock.Setup(m => m.GuardarPedido(It.IsAny<Pedido>()))
                .ReturnsAsync(new ResponseLogistica());

            FacturacionService facturacionService = new FacturacionService(pagoServiceMock.Object);
            #endregion

            #region Act
            var response = facturacionService.GuardarPedido(new Pedido());
            #endregion

            #region Assert
            Assert.IsType<ResponseLogistica>(response.Result);
            #endregion

        }

        [Fact]
        public void FacturacionService_CalcularPedido_OK()
        {
            #region Arrange
            var pagoServiceMock = new Mock<IPagoService>();

            FacturacionService facturacionService = new FacturacionService(pagoServiceMock.Object);
            #endregion

            #region Act
            var response = facturacionService.CalcularPedido(new List<Productos>());
            #endregion

            #region Assert
            Assert.IsType<Response>(response);
            #endregion

        }

        [Fact]
        public void FacturacionService_CalcularPedido_Error()
        {
            #region Arrange
            var pagoServiceMock = new Mock<IPagoService>();

            FacturacionService facturacionService = new FacturacionService(pagoServiceMock.Object);
            #endregion

            #region Act
            var response = facturacionService.CalcularPedido(new List<Productos>());
            #endregion

         

            #region Assert
            Assert.Throws<Exception>(() => facturacionService.CalcularPedido(null));
            #endregion
        }

    }
}
