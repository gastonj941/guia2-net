using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Energia { get; set; }
        public string Tamaño { get; set; }
        public Persona Regazo { get; set; }

        public Mascota(string nombre, string tipo, string tamaño)
        {
            Nombre = nombre;
            Tipo = tipo;
            Energia = 100;
            Tamaño = tamaño;
            Regazo = null;
        }

        public void Alimentar()
        {
            if ((Energia + 30) > 100)
            {
                Energia = 100;
            }
            else
            {
                Energia += 30;
            }
        }

        public void Correr()
        {
            if (Energia > 20)
            {
                Energia -= 10;
            }
        }
    }
}
