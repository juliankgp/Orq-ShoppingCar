using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Pagos.Models.Models
{
    public class Productos
    {
        [RegularExpression(@"^[\d]*", ErrorMessage = "Formato de id invalido")]
        public int idProducto { get; set; }

        [RegularExpression(@"^[\d]*", ErrorMessage = "Formato cantidad invalido")]
        public int Cantidad { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obligatorio")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "Formato Nombre invalido")]
        public string? Nombre { get; set; }

        [StringLength(100, MinimumLength = 0, ErrorMessage = "Formato descripcion invalido")]
        public string? Descripcion { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obligatorio")]
        [RegularExpression(@"^[\d]*", ErrorMessage = "Formato precio invalido")]
        public string? Precio { get; set; }
        
        public string? Img { get; set; }
    }
}
