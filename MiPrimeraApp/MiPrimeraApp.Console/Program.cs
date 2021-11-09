using System;
using System.Collections.Generic;
using MiPrimeraApp.Dominio;
using MiPrimeraApp.Persistencia;

namespace MiPrimeraApp.Console
{
     
    class Program
    {
        private static IRepositorioPaciente _Repopaciente = new RepositorioPaciente();
        static void Main(string[] args)
        {
            
            //AddPaciente();
            MostrarPacientes();
           
        }
         private void AddPaciente()
         {
             var paciente = new Paciente
             {
                 Nombre= "pepito",
                 Apellidos="perez",
                 NumTelefono="60688888",
                 Genero=Genero.Masculino,
                 Direccion="Calle 18 n 1-2",
                 Ciudad="Manizales",
                 FechadeNacimiento= new DateTime(1994,04,12)
             };
             _RepoPaciente.AddPaciente(paciente);

         }
         private void MostrarPacientes()
         {
             IEnumerable<Paciente> pacientes = RepoPaciente.GetAllpacientes();
        {
            return _appContex.pacientes;
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre+""+paciente.Apellidos+""+paciente.Genero);
            }
        }
         }
    }
}
