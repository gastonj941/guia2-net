using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Smartphone
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool Encendido { get; set; }
        public int Volumen { get; set; }
        public int Brillo { get; set;}

        public Smartphone(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Encendido = false;
            Volumen = 50;
            Brillo = 50;
        }

        public void PrenderApagar()
        {
            Encendido = !Encendido;
        }

        public void Silencio()
        {
            Volumen = 0;
        }

        public void SubirVolumen()
        {
            if ((Volumen + 10) > 100)
            {
                Volumen = 100;
            }
            else
            {
                Volumen+= 10;
            }
        }

        public void BajarVolumen()
        {
            if ((Volumen - 10) < 0)
            {
                Volumen = 0;
            }
            else
            {
                Volumen -= 10;
            }
        }

        public void SubirBrillo()
        {
            if ((Brillo + 10) > 100)
            {
                Brillo = 100;
            }
            else
            {
                Brillo += 10;
            }
        }

        public void BajarBrillo()
        {
            if ((Brillo - 10) < 0)
            {
                Brillo = 0;
            }
            else
            {
                Brillo -= 10;
            }
        }


    }
}
