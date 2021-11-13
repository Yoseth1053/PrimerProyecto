using System.Collections.Generic;
using MiPrimeraApp.Dominio;

namespace MiPrimeraApp.Persistencia
{
    public class RepositorioSignoVital : IRepositorioSignoVital
    {
        private readonly AppContext _appContext new AppContext();
        SignoVital IRepositorioSignoVital.AddSignoVital(SignoVital signoVital)
        {
            var signoVitalAdicionado = _appContext.SignosVitales.Add(signoVital);
            _appContext.SaveChanges();
            return signoVitalAdicionado.Entity;
        }

        Paciente IRepositorioSignoVital.AsignarPaciente(int idSignoVital, int idPaciente)
        {
            var signoVitalEncontrado = _appContext.SignosVitales.Find(idSignoVital);
            if(signoVitalEncontrado != null)
            {
                var pacienteEncontrado = _appContext.Paciente.Find(idPaciente);
                if(pacienteEncontrado != null)
                {
                    signoVitalEncontrado.Paciente = pacienteEncontrado;
                    _appContext.SaveChanges();

                }
                return pacienteEncontrado;
            }
            return null;

        }
    }
}