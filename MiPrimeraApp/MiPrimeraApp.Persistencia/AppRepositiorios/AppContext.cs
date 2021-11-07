using Microsoft.EntityFrameworkCore;
using MiPrimeraApp.Dominio;

namespace MiPrimeraApp.Persistencia
{
    public class AppContext  : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Paciente> Pacientes {get; set;}
        public DbSet<Medico> Medicos {get; set;}
        public DbSet<SignoVital> SignosVitales {get; set;}
        
        
    }
}