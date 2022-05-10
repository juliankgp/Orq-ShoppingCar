using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Pagos.Services.RestServices
{
    public interface IRestService
    {
        Task<T> GetRestService<T>(string url, IDictionary<string, string> headers);
        Task<T> PostRestService<T>(string url, IDictionary<string, string> headers, object body);
    }
}
