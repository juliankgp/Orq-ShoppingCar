using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Pagos.Models.Models
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string Img { get; set; }
    }
}
