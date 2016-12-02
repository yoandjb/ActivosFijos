using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class Proovedor
    {
        [Key]
        public int Proveedor { get; set; }
        [Required(
         AllowEmptyStrings = false,
         ErrorMessage = "Ingresar nombre del proveedor")]
        public String Nombre { get; set; }

        [Required(
   AllowEmptyStrings = false,
   ErrorMessage = "La cedula es obligatoria")]

        [StringLength(12, MinimumLength = 12)]
        public String Cedula { get; set; }
        public string Tipodepersona { get; set; }
        public DateTime Fechadeingreso { get; set; }
        public String Estado { get; set; }
    }
}