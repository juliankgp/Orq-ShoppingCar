using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Pagos.Models.Models
{
    public class Response
    {
        public bool Exitoso{ get; set; }
        public int Code { get; set; }
        public Result Data { get; set; }
    }
}
