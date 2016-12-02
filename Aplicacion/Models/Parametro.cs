using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class Parametro
    {
        [Key]
        public int Id_Parametro { get; set; }

        public DateTime Fecha_Proceso { get; set; }
        public string Depreciacion { get; set; }
        [StringLength(9, MinimumLength = 9)]
        public string Rnc { get; set; }

        public string Metodo_Depreciacion { get; set; }
    }
}