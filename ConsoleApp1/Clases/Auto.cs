using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set;}
        public string Color { get; set; }
        public bool Encendido { get; set;}
        public int Velocidad { get; set; }
        public Persona Conductor { get; set; }
        public int Capacidad { get; set; }
        public List<Persona> Pasajeros { get; set; }
        public Mascota Mascota { get; set; }

        public Auto(string marca, string modelo, string color, int capacidad)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Encendido = false;
            Velocidad = 0;
            Capacidad = capacidad;
        }
        public Auto(string marca, string modelo, string color, Persona conductor)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Encendido = false;
            Velocidad = 0;
            Conductor = conductor;
        }

        public void Encender()
        {
            if(Conductor!=null && Conductor.CalcularEdad()>=18)
            {
                Encendido = true;
            }
            else
            {
                Console.WriteLine("No hay conductor");
            }
        }

        public void Apagar()
        {
            Encendido = false;
        }

        public void Acelerar()
        {
            if (Encendido && (Velocidad + 10) > 100)
            {
                Velocidad = 100;
            }
            else
            {
                Velocidad += 10;
            }
        }

        public void Frenar()
        {
            if ((Velocidad - 10) < 0)
            {
                Velocidad = 0;
            }
            else
            {
                Velocidad -= 20;
            }
        }

        public void SubirPasajero(Persona pasajero)
        {
            if (HayLugar())
            {
                Pasajeros.Add(pasajero);
            }
        }

        public bool HayLugar()
        {
            int lugaresDisponibles = Pasajeros.Count - Capacidad;
            if (Mascota.Tamaño == "grande")
            {
                lugaresDisponibles-=1;
            }
            return lugaresDisponibles > 0;
        }

        public void SubirMascotaGrande(Mascota mascota)
        {
            if (Conductor != null)
            {
                if (mascota.Tamaño == "grande")
                {
                    if (HayLugar())
                    {
                        Mascota = mascota;
                    }
                    else
                    {
                        Console.WriteLine("No hay lugar");
                    }
                }
                else
                {
                    Console.WriteLine("Es una mascota pequeña debe ir en el regazo de un pasajero");
                }
            }
            else
            {
                Console.WriteLine("No hay conductor");
            }
        }


        public void BajarPasajero(Persona pasajero)
        {
            if (Velocidad == 0)
            {
                Pasajeros.Remove(pasajero);
                if (Mascota.Regazo == pasajero)
                {
                    Mascota = null;
                }
            }
        }

        public void BajarPasajeros()
        {
            if (Velocidad == 0)
            {
                Pasajeros.Clear();
                Mascota = null;
            }
        }

        public void BajarConductor()
        {
            if(Encendido==false)
            {
                Conductor = null;
            }
            else
            {
                Console.WriteLine("El auto está en marcha");
            }
        }

        public void BajarMascotaGrande()
        {
            if (Mascota.Tamaño == "grande")
            {
                Mascota = null;
            }
            else
            {
                Console.WriteLine("No es una mascota grande");
            }
        }

        public void SubirRegazo(Mascota mascota, Persona pasajero)
        {
            if (mascota.Tamaño == "pequeño")
            {
                if (Pasajeros.Contains(pasajero))
                {
                    Mascota = mascota;
                    mascota.Regazo = pasajero;
                }
                else
                {
                    Console.WriteLine("El pasajero no se encuentra en el auto");
                }
            }
            else
            {
                Console.WriteLine("No es una mascota pequeño");
            }
        }

        public void CambiarRegazoMascota(Persona pasajero)
        {
            if (Mascota.Tamaño == "pequeño")
            {
                Mascota.Regazo = pasajero;
            }
            else
            {
                Console.WriteLine("No es una mascota pequeña");
            }
        }

        public void ConocerRegazo()
        {
            if (Mascota.Regazo != null)
            {
                Console.WriteLine("La mascota va en el regazo de "+ Mascota.Regazo.NombreCompleto());
            }
            else
            {
                Console.WriteLine("No hay mascotas en el regazo de nadie");
            }
        }
    }
}
