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
        

        
    }
}