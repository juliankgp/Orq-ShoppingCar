using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Pagos.Models.Models
{
    public class Pedido : Cliente
    {
        public List<Productos> productos { get; set; }

    }
}
