using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewLabBlazor.Entities
{
    public class Facturacion
    {
        [Key]
        public int Id { get; set; }
        public Prueba prueba { get; set; }

        [Required]
        public int MontoAFacturar { get; set; }

    }
}
