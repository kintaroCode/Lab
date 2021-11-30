using Microsoft.EntityFrameworkCore;
using NewLabBlazor.Entities;

namespace NewLabsys.DataContext
{
    public partial class LabDbContext:DbContext
    {
        public LabDbContext(DbContextOptions<LabDbContext> options):base(options)
        {
            
        }

        public DbSet<Analisis> Analisis {get;set;}
        public DbSet<Facturacion> Facturacion {get;set;}
        public DbSet<ObraSocial> ObraSocial {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        public DbSet<Prueba> Pruebas {get;set;}
        
    } 
    
}