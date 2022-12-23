using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Cuadrado
    {
        public int Lado { get; set; }

        public Cuadrado(int lado)
        {
            Lado = lado;
        }

        public double CalcularArea()
        {
            return Math.Pow(Lado, 2);
        }
    }
}
