using System.Collections.Generic;
using System.Linq;
using MiPrimeraApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MiPrimeraApp.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContex = new AppContext(); 
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContex.Pacientes.Add(paciente);
            _appContex.SaveChanges();
            return pacienteAdicionado.Entity;
        }
        IEnumerable<Paciente> IRepositorioPaciente.GetAllpacientes()
        {
            return _appContex.pacientes;
        }
    }
}