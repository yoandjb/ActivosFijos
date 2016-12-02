using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class Empleado
    {
        [Key]
        public int Id_Empleado { get; set; }
        [Required(
                AllowEmptyStrings = false,
                ErrorMessage = "El nombre es obligatorio")]
        public String nombre { get; set; }
        [StringLength(12, MinimumLength = 12)]
        public String cedula { get; set; }
        [Required(
             AllowEmptyStrings = false,
             ErrorMessage = "El departamento es obligatorio")]
        public String Departamento { get; set; }

        public String Tipodepersona { get; set; }
        public DateTime Fechadeingreso { get; set; }

        public String Estado { get; set; }
    }
}