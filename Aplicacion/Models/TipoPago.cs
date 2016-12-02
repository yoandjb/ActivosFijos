using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class TipoPago
    {
        [Key]
        public int Id_Pagos { get; set; }
        [Required(
               AllowEmptyStrings = false,
               ErrorMessage = "Ingrese una descripcion")]
        public String Descripcion { get; set; }
        [Required(
              AllowEmptyStrings = false,
              ErrorMessage = "Ingrese el estado de pago")]
        public String Estado { get; set; }
    }
}