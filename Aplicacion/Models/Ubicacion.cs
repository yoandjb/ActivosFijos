using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class Ubicacion
    {
        [Key]
        public int Id_Ubicaciones { get; set; }
        [Required(
        AllowEmptyStrings = false,
        ErrorMessage = "Ingrese la descripcion")]
        public string Descripcion { get; set; }
        [Required(
              AllowEmptyStrings = false,
              ErrorMessage = "La direccion es obligatoria")]
        public string Direccion { get; set; }
        public string Edificio { get; set; }
        public string Estado { get; set; }
    }
}