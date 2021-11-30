using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewLabBlazor.Entities
{
    [Index(nameof(Protocolo), IsUnique=true)]
    public class Prueba
    {
        public int Id { get; set; }
        public int Protocolo { get; set; }

        [Required]
        public DateTime FechaRealizado { get; set; }

        [Required]
        public Paciente Paciente { get; set; }
        public List<Analisis> Analisis { get; set; }

    }
}
