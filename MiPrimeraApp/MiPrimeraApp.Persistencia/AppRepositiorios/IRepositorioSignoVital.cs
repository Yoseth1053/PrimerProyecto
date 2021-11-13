namespace MiPrimeraApp.Persistencia
{
    public interface IRepositorioSignoVital
    {
         IEnumerable<SignoVital> GetAllSignosVitales();
         SignoVital AddSignoVital(signoVital signoVital);
         SignoVital GetSignoVital(int idSignoVital);
         Paciente AsignarPaciente(int idSignoVital, int idPaciente);

    }
}