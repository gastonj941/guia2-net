using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Estudiante : Persona
    {
        public List<Libro> Libros { get; set; }

        public Estudiante(string nombre, string apellido, DateTime fechaNacimiento) : base(nombre, apellido, fechaNacimiento)
        {
        }

        public Estudiante(string nombre, string apellido, DateTime fechaNacimiento, Smartphone celular) : base(nombre, apellido, fechaNacimiento, celular)
        {
        }

        public Estudiante(string nombre, string apellido, DateTime fechaNacimiento, List<Libro> libros) : base(nombre, apellido, fechaNacimiento)
        {
            Libros = libros;
        }
        public Estudiante(string nombre, string apellido, DateTime fechaNacimiento, Smartphone celular, List<Libro> libros) : base(nombre, apellido, fechaNacimiento, celular)
        {
            Libros = libros;
        }

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public void QuitarLibro(Libro libro)
        {
            Libros.Remove(libro);
        }

        public List<Libro> Leidos()
        {
            List<Libro> leidos = new List<Libro>();

            foreach(Libro libro in Libros)
            {
                if (libro.WasRead == true)
                {
                    leidos.Add(libro);
                }
            }

            return leidos;
        }

        public int PaginasLeidas()
        {
            int paginasLeidas=0;
            foreach(Libro libro in Leidos())
            {
                paginasLeidas += libro.CantidadPaginas;
            }
            return paginasLeidas;
        }

        public int CantidadLibrosSinLeer()
        {
            List<Libro> noLeidos = new List<Libro>();

            foreach (Libro libro in Libros)
            {
                if (libro.WasRead == false)
                {
                    noLeidos.Add(libro);
                }
            }

            return noLeidos.Count;
        }
    }
}
