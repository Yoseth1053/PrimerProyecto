using System;
using System.Collections.Generic;
using MiPrimeraApp.Dominio;


namespace MiPrimeraApp.Persistencia
{
    public interface IRepositorioPaciente
    {
         IEnumerable<Paciente> GetAllPacientes();

         Paciente AddPaciente(Paciente paciente);

         Paciente GetPaciente(int idPaciente);

            
    }
}