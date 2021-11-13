using System;
using System.Collections.Generic;
using MiPrimeraApp.Dominio;
using MiPrimeraApp.Persistencia;

namespace MiPrimeraApp.Console
{
     
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        static void Main(string[] args)
        {
            Console.WriteLine(" Bienvenidos 9 Noviembre");
            //AddPaciente();
            //MostrarPacientes();
            //BuscarPacientes();
           
        }
         private static void AddPaciente()
         {
             var paciente = new Paciente
             {
                 Nombre= "pepito",
                 Apellidos="perez",
                 NumeroTelefono="60688888",
                 Genero=Genero.Masculino,
                 Direccion="Calle 18 n 1-2",
                 Ciudad="Manizales",
                 FechaNacimiento= new DateTime(1994,04,12)
             };
             _repoPaciente.AddPaciente(paciente);

         }
         private static void MostrarPaciente()
         {
             IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPacientes();
        
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
            }
         }
            
            private static void BuscarPaciente(int idPaciente)
            {
                var paciente  = _repoPaciente.GetPaciente(idPaciente);
                Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
            }
        
         
    }
}