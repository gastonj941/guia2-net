using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Libro
    {
        public string Nombre { get; set; }
        public Persona Autor { get; set; }
        public int CantidadPaginas { get; set; }
        public bool WasRead { get; set; }

        public Libro(string nombre, Persona autor, int cantidadPaginas)
        {
            Nombre = nombre;
            Autor = autor;
            CantidadPaginas = cantidadPaginas;
            WasRead = false;
        }
    }
}
