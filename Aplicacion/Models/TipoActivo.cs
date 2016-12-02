using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class TipoActivo
    {
        [Key]
        public int Activo { get; set; }
        [Required(
                AllowEmptyStrings = false,
                ErrorMessage = "La descripcion no puede estar vacia")]
        public String Descripcion { get; set; }
        public String Cuentascontablecompra { get; set; }
        public String Cuentacontabledepreciacion { get; set; }
        [Required(
                AllowEmptyStrings = false,
                ErrorMessage = "El estado no puede estar vacio")]
        public String Estado { get; set; }
    }
}