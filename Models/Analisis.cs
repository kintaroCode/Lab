using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewLabBlazor.Entities
{
    public class Analisis
    {   
        [Key]
        public int NumeroNomenclador { get; set; }

        [MaxLength(100)]
        public string NombreAnalisis { get; set; }

        [Required]
        public int UnidadValor { get; set; }

        [Required]
        public bool Externo { get; set; }
    }
}
