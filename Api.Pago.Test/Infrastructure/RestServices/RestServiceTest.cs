using Api.Pagos.Models.Models;
using Api.Pagos.Services.RestServices;
using Moq;
using Newtonsoft.Json;
using RichardSzalay.MockHttp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;

namespace Api.Pago.Test.Infrastructure.RestServices
{
    public class RestServiceTest
    {
        readonly string url = "";
        [Fact]
        public void RestService_GetRestService_OK()
        {
            //    #region Arrange
            //    string currentUrl = "https://localhost:44300/api/Pedido/GuardarPedido";

            //    var httpClientFactoryMock = new Mock<IHttpClientFactory>();
            //    httpClientFactoryMock.Setup(h => h.CreateClient(It.IsAny<string>()))
            //        .Returns(new HttpClient());

            //    var mockHttp = new MockHttpMessageHandler();
            //    mockHttp.When(currentUrl)
            //        .Respond("application/json", JsonConvert.SerializeObject(new Response()));

            //    var client = new HttpClient(mockHttp);

            //    Dictionary<string, string> dictionaries = new Dictionary<string, string>();

            //    RestService restService = new RestService(httpClientFactoryMock.Object);
            //    #endregion

            //    #region Act
            //    var response = restService.GetRestService<Response>(currentUrl, dictionaries);
            //    #endregion

            //    #region Assert
            //    Assert.IsType<Response>(response.Result);
            //    #endregion

        }
        [Fact]
        public void RestService_GetRestService_Error()
        {
            //    #region Arrange
            //    string currentUrl = "https://localhost:44300/api/Pedido/GuardarPedido";

            //    var httpClientFactoryMock = new Mock<IHttpClientFactory>();
            //    httpClientFactoryMock.Setup(h => h.CreateClient(It.IsAny<string>()))
            //        .Returns(new HttpClient());

            //    var mockHttp = new MockHttpMessageHandler();
            //    mockHttp.When(currentUrl)
            //        .Respond("application/json", JsonConvert.SerializeObject(new Response()));

            //    var client = new HttpClient(mockHttp);

            //    Dictionary<string, string> dictionaries = new Dictionary<string, string>();

            //    RestService restService = new RestService(httpClientFactoryMock.Object);
            //    #endregion

            //    #region Act
            //    var response = restService.GetRestService<Response>(currentUrl, dictionaries);
            //    #endregion

            //    #region Assert
            //    Assert.IsType<Response>(response.Result);
            //    #endregion

        }

        [Fact]
        public void RestService_PostRestService_OK()
        {
            //    #region Arrange
            //    string currentUrl = "https://localhost:44300/api/Pedido/GuardarPedido";

            //    var httpClientFactoryMock = new Mock<IHttpClientFactory>();
            //    httpClientFactoryMock.Setup(h => h.CreateClient(It.IsAny<string>()))
            //        .Returns(new HttpClient());

            //    var mockHttp = new MockHttpMessageHandler();
            //    mockHttp.When(currentUrl)
            //        .Respond("application/json", JsonConvert.SerializeObject(new Response()));

            //    var client = new HttpClient(mockHttp);

            //    Dictionary<string, string> dictionaries = new Dictionary<string, string>();

            //    RestService restService = new RestService(httpClientFactoryMock.Object);
            //    #endregion

            //    #region Act
            //    var response = restService.GetRestService<Response>(currentUrl, dictionaries);
            //    #endregion

            //    #region Assert
            //    Assert.IsType<Response>(response.Result);
            //    #endregion

        }

        [Fact]
        public void RestService_PostRestService_Error()
        {
            //    #region Arrange
            //    string currentUrl = "https://localhost:44300/api/Pedido/GuardarPedido";

            //    var httpClientFactoryMock = new Mock<IHttpClientFactory>();
            //    httpClientFactoryMock.Setup(h => h.CreateClient(It.IsAny<string>()))
            //        .Returns(new HttpClient());

            //    var mockHttp = new MockHttpMessageHandler();
            //    mockHttp.When(currentUrl)
            //        .Respond("application/json", JsonConvert.SerializeObject(new Response()));

            //    var client = new HttpClient(mockHttp);

            //    Dictionary<string, string> dictionaries = new Dictionary<string, string>();

            //    RestService restService = new RestService(httpClientFactoryMock.Object);
            //    #endregion

            //    #region Act
            //    var response = restService.GetRestService<Response>(currentUrl, dictionaries);
            //    #endregion

            //    #region Assert
            //    Assert.IsType<Response>(response.Result);
            //    #endregion

        }

    }
}
