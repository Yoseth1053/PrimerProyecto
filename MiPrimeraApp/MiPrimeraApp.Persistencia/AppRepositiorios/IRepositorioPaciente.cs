using System.Collections.Generic;
using MiPrimeraApp.Dominio;


namespace MiPrimeraApp.Persistencia
{
    public interface IRepositorioPaciente
    {
         IEnumerable<paciente> GetAllpacientes();
         Paciente AddPaciente(Paciente paciente)
         {

         }
         
    }
}