using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Pagos.Models.Models
{
    public class Result
    {
        public int? Id { get; set; }
        public double  Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        //public Pedido pedido { get; set; }

    }
}
