using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Pagos.Models.Models
{
    public class Cliente
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Formato invalido")]
        public string Nombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obligatorio")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "Formato invalido")]
        public string Direccion { get; set; }
        
        [RegularExpression(@"^[\d]*", ErrorMessage ="Formato de telefono invalido")]
        public string Telefono { get; set; }

        [RegularExpression(@"^[\d]*", ErrorMessage = "Formato de impuestos invalido")]
        public string Impuestos { get; set; }

        [RegularExpression(@"^[\d]*", ErrorMessage = "Formato de subtotal invalido")]
        public string Subtotal { get; set; }

        [RegularExpression(@"^[\d]*", ErrorMessage = "Formato de total invalido")]
        public string Total { get; set; }

    }
}
