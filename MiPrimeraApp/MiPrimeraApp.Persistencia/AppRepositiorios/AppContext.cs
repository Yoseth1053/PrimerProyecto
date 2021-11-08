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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Inital catalog=HospitalAdsi2207208; DataSource=DESKTOP-G6077QO;  Integrated Security=true");
                /*initial cataloh : Nombre de base de datos
                source : nombre del servidor de la base de datos
                integrated security: seguridad con la misma configuracion del inicio de secion*/

            }
        }
        
    }
}