﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLabBlazor.Entities
{
    public class Paciente
    {
        public int Id { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion  { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Internado { get; set; }
        public List<Prueba> Prueba {get; set; }
        public ObraSocial ObraSocial { get; set; }
    }
}
