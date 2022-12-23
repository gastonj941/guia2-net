using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Smartphone Celular { get; set; }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento= fechaNacimiento;
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, Smartphone celular)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Celular = celular;
        }

        public string NombreCompleto()
        {
            return Nombre+" "+Apellido;
        }

        public int CalcularEdad()
        {
            return DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;
        }

    }
}
