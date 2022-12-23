using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Guia
    {
        //ejercicio1
        public string MayorQue100(int numero)
        {
            if (numero > 100)
            {
                return "El valor es mayor que 100";
            }
            else
            {
                return "El valor no es mayor que 100";
            }
        }

        //ejercicio2
        public bool EsPar(int numero)
        {
            return (numero % 2) == 0;
        }

        //ejercicio3
        public bool DobleDeImpar(int numero)
        {
            return ((numero / 2) % 2) != 0;
        }

        //ejercicio4
        public string Romanos(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                case 10:
                    return "X";
                default:
                    return "No ingreso un numero del 1 al 10";
            }
        }

        //ejercicio5
        public string DiferenciaEdad(string nombre1, int edad1, string nombre2, int edad2)
        {
            int resultado = edad1 - edad2;

            switch (resultado)
            {
                case 0:
                    return "Las dos personas tienen la misma edad";
                case < 0:
                    return $"El menor es {nombre1}, y la diferencia es de {Math.Abs(resultado)} años";
                case > 0:
                    return $"El menor es {nombre2}, y la diferencia es de {resultado} años";
            }
        }

        //ejercicio6
        public string ClasificacionTriangulo(int lado1, int lado2, int lado3)
        {
            if (lado1 == lado2 && lado1 == lado3)
            {
                return "Es un triangulo equilatero";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Es un triangulo isosceles";
            }
            else
            {
                return "Es un triangulo escaleno";
            }
        }

        public double PerimetroTriangulo(int lado1, int lado2, int lado3)
        {
            return lado1 + lado2 + lado3;
        }

        public double AreaTriangulo(int lado1, int lado2, int lado3)
        {
            double s = this.PerimetroTriangulo(lado1, lado2, lado3) / 2;
            return Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }

        //ejercicio7
        public string Desglose(int monto)
        {
            string texto = "";
            int contador = 0;
            int[] billetes = new int[10] { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int billete in billetes)
            {
                while ((monto - billete) >= 0)
                {
                    monto -= billete;
                    contador++;
                }
                string denominacion;
                if (billete > 5)
                {
                    denominacion = " billete/s";
                }
                else
                {
                    denominacion = " moneda/s";
                }

                if (contador > 0)
                {
                    texto = texto + contador + denominacion + " de " + billete + " ";
                }
                contador = 0;
            }
            return texto;
        }

        //ejercicio8
        public string UnoAN(int n)
        {
            string cadena = "";
            for (int i = 1; i <= n; i++)
            {
                cadena += i + " ";
            }

            return cadena;
        }

        //ejercicio9
        public void Suma15Numeros()
        {
            int[] sumando = new int[15];
            int suma = 0;
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine($"Ingresar {i}º numero:");
                var option = Console.ReadLine();
                Int32.TryParse(option, out sumando[i - 1]);
            }

            for (int i = 0; i < 15; i++)
            {
                suma += sumando[i];
            }

            Console.WriteLine(suma);
        }

        //ejercicio10
        public void MultiploDeTres()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Ingresar {i}º numero:");
                var option = Console.ReadLine();
                int num;
                Int32.TryParse(option, out num);
                if ((num % 3) == 0)
                {
                    Console.WriteLine("Es multiplo de 3");
                }
            }
        }

        //ejercicio11
        public void Password()
        {
            string pass, pass2;
            Console.WriteLine("Ingresar contraseña:");
            pass = Console.ReadLine();
            Console.WriteLine("Reingresar contraseña:");
            pass2 = Console.ReadLine();

            while (pass != pass2)
            {
                Console.WriteLine("Las contraseñas no coinciden. Reingresar contraseña:");
                pass2 = Console.ReadLine();
            }
        }

        //ejercicio12
        public void PasswordTresIntentos()
        {
            string password, password2;
            Console.WriteLine("Ingresar contraseña:");
            password = Console.ReadLine();
            Console.WriteLine("Reingresar contraseña:");
            password2 = Console.ReadLine();
            int intentos = 1;
            while (intentos < 3)
            {
                if (password != password2)
                {
                    Console.WriteLine("Las contraseñas no coinciden. Reingresar contraseña:");
                    password2 = Console.ReadLine();
                }
                intentos++;
            }
        }

        //ejercicio13
        public void Adivinanza()
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(10);

            Console.WriteLine("Adivinar numero:");
            var adivinanza = Console.ReadLine();
            int adivina;
            Int32.TryParse(adivinanza, out adivina);
            while (adivina != aleatorio)
            {
                Console.WriteLine("Equivocado. Intente otra vez:");
                adivinanza = Console.ReadLine();
                Int32.TryParse(adivinanza, out adivina);
            }
            Console.WriteLine("Correcto");
        }

        //ejercicio14
        public void AdivinanzaConPista()
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(10);

            Console.WriteLine("Adivinar numero:");
            var adivinanza = Console.ReadLine();
            int adivina;
            Int32.TryParse(adivinanza, out adivina);
            while (adivina != aleatorio)
            {
                if (adivina > aleatorio)
                {
                    Console.WriteLine("Equivocado. El numero es menor. Intente otra vez:");
                }
                else
                {
                    Console.WriteLine("Equivocado. El numero es mayor. Intente otra vez:");
                }
                adivinanza = Console.ReadLine();
                Int32.TryParse(adivinanza, out adivina);
            }
            Console.WriteLine("Correcto");
        }

        //ejercicio15
        public void SumaNNumeros()
        {
            Console.WriteLine("Ingrese el numero que quiere sumar('fin' para terminar):");
            var elemento = Console.ReadLine();
            int sumaDeNumeros = 0, nuevoElemento;

            while (elemento != "fin")
            {
                Int32.TryParse(elemento, out nuevoElemento);
                sumaDeNumeros += nuevoElemento;
                Console.WriteLine($"suma: {sumaDeNumeros}");
                Console.WriteLine("Ingrese el numero que quiere sumar('fin' para terminar):");
                elemento = Console.ReadLine();
            }
        }
    }
}
