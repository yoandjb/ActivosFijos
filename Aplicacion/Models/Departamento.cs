using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class Departamento
    {
        [Key]
        public int Id_departamento { get; set; }
        [Required(
             AllowEmptyStrings = false,
             ErrorMessage = "La descripcion es obligatoria")]
        public String Descripcion { get; set; }
        public String Estado { get; set; }
    }
}