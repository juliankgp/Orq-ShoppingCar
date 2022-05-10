using Api.Pagos.Models.Models;
using Api.Pagos.Services.RestServices;
using Api.Pagos.Services.Services;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Api.Pago.Test.Infrastructure.Services
{
    public class PagoServiceTest
    {

        [Fact]
        public void FacturacionService_GetPedidos_OK()
        {
            #region Arrange
            var restServiceMock = new Mock<IRestService>();
            restServiceMock.Setup(m => m.GetRestService<List<Pedido>>(It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()))
                .ReturnsAsync(new List<Pedido>());

            var configMock = new Mock<IConfiguration>();
            configMock.Setup(c => c.GetSection(It.IsAny<string>()))
                .Returns(new Mock<IConfigurationSection>().Object);

            PagoService pagoService = new PagoService(restServiceMock.Object, configMock.Object);
            #endregion

            #region Act
            var response = pagoService.GetPedidosI();
            #endregion

            #region Assert
            Assert.IsType<List<Pedido>>(response.Result);
            #endregion
        }

        [Fact]
        public void FacturacionService_GetPedidos_Error()
        {
            #region Arrange
            var restServiceMock = new Mock<IRestService>();
            restServiceMock.Setup(m => m.GetRestService<List<Pedido>>(It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()))
                .ReturnsAsync(() => throw new Exception("Exception"));

            var configMock = new Mock<IConfiguration>();
            configMock.Setup(c => c.GetSection(It.IsAny<string>()))
                .Returns(new Mock<IConfigurationSection>().Object);

            PagoService pagoService = new PagoService(restServiceMock.Object, configMock.Object);
            #endregion

            #region Act
            #endregion

            #region Assert
            Assert.Throws<AggregateException>(() => pagoService.GetPedidosI().Result);
            #endregion
        }

        [Fact]
        public void FacturacionService_GetPedidosByIdI_OK()
        {
            #region Arrange
            var restServiceMock = new Mock<IRestService>();
            restServiceMock.Setup(m => m.GetRestService<Pedido>(It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()))
                .ReturnsAsync(new Pedido());

            var configMock = new Mock<IConfiguration>();
            configMock.Setup(c => c.GetSection(It.IsAny<string>()))
                .Returns(new Mock<IConfigurationSection>().Object);

            PagoService pagoService = new PagoService(restServiceMock.Object, configMock.Object);
            #endregion

            #region Act
            var response = pagoService.GetPedidosByIdI(5);
            #endregion

            #region Assert
            Assert.IsType<Pedido>(response.Result);
            #endregion
        }


        [Fact]
        public void FacturacionService_GetPedidosByIdI_Error()
        {
            #region Arrange
            var restServiceMock = new Mock<IRestService>();
            restServiceMock.Setup(m => m.GetRestService<Pedido>(It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()))
                .ReturnsAsync(() => throw new Exception("Exception"));

            var configMock = new Mock<IConfiguration>();
            configMock.Setup(c => c.GetSection(It.IsAny<string>()))
                .Returns(new Mock<IConfigurationSection>().Object);

            PagoService pagoService = new PagoService(restServiceMock.Object, configMock.Object);
            #endregion

            #region Act
            #endregion

            #region Assert
            Assert.Throws<AggregateException>(() => pagoService.GetPedidosByIdI(1).Result);
            #endregion
        }

        [Fact]
        public void FacturacionService_GuardarPedido_OK()
        {
            #region Arrange
            var restServiceMock = new Mock<IRestService>();
            restServiceMock.Setup(m => m.PostRestService<ResponseLogistica>(It.IsAny<string>(), It.IsAny<Dictionary<string, string>>(), It.IsAny<object>()))
                .ReturnsAsync(new ResponseLogistica());

            var configMock = new Mock<IConfiguration>();
            configMock.Setup(c => c.GetSection(It.IsAny<string>()))
                .Returns(new Mock<IConfigurationSection>().Object);

            PagoService pagoService = new PagoService(restServiceMock.Object, configMock.Object);
            #endregion

            #region Act
            var response = pagoService.GuardarPedido(new Pedido());
            #endregion

            #region Assert
            Assert.IsType<ResponseLogistica>(response.Result);
            #endregion
        }

        [Fact]
        public void FacturacionService_GuardarPedido_Error()
        {
            #region Arrange
            var restServiceMock = new Mock<IRestService>();
            restServiceMock.Setup(m => m.PostRestService<ResponseLogistica>(It.IsAny<string>(), It.IsAny<Dictionary<string, string>>(), It.IsAny<object>()))
                .ReturnsAsync(() => throw new Exception("Exception"));

            var configMock = new Mock<IConfiguration>();
            configMock.Setup(c => c.GetSection(It.IsAny<string>()))
                .Returns(new Mock<IConfigurationSection>().Object);

            PagoService pagoService = new PagoService(restServiceMock.Object, configMock.Object);
            #endregion

            #region Act
            #endregion

            #region Assert
            Assert.Throws<AggregateException>(() => pagoService.GuardarPedido(new Pedido()).Result);
            #endregion
        }
    }
}
