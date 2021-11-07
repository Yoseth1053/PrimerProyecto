using System;
using System.Collections.Generic;

namespace MiPrimeraApp.Dominio
{
    public class Paciente : Persona
    {
        public string Direccion {get; set;}
        public string Ciudad {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public Medico Medico {get; set;}
        public List<SignoVital> SignosVitales {get; set;}
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