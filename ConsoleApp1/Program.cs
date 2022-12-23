using ConsoleApp1.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        #region clase guia
        //Guia nuevaguia = new Guia();

        ////ejercicio1
        //Console.WriteLine(nuevaguia.MayorQue100(101));

        ////ejercicio2
        //Console.WriteLine("Ingresar numero:");
        //var option = Console.ReadLine();
        //int num;
        //Int32.TryParse(option, out num);
        //if (nuevaguia.EsPar(num))
        //{
        //    Console.WriteLine("Es par");
        //}
        //else
        //{
        //    Console.WriteLine("No es par. Es impar");
        //}
        ////ejercicio3
        //Console.WriteLine(nuevaguia.DobleDeImpar(14));

        ////ejercicio4
        //Console.WriteLine(nuevaguia.Romanos(7));

        ////ejercicio5
        //Console.WriteLine("Ingresar nombre de la persona 1:");
        //var nombre1 = Console.ReadLine();
        //Console.WriteLine("Ingresar edad de la persona 1:");
        //var edad1 = Console.ReadLine();
        //Console.WriteLine("Ingresar nombre de la persona 2:");
        //var nombre2 = Console.ReadLine();
        //Console.WriteLine("Ingresar edad de la persona 2:");
        //var edad2 = Console.ReadLine();

        //int num1, num2;

        //Int32.TryParse(edad1, out num1);
        //Int32.TryParse(edad2, out num2);

        //Console.WriteLine(nuevaguia.DiferenciaEdad(nombre1, num1, nombre2, num2));

        ////ejercicio6
        //Console.WriteLine("Ingresar longitud del lado 1:");
        //var longitud1 = Console.ReadLine();
        //Console.WriteLine("Ingresar longitud del lado 2:");
        //var longitud2 = Console.ReadLine();
        //Console.WriteLine("Ingresar longitud del lado 3:");
        //var longitud3 = Console.ReadLine();

        //int lado1, lado2, lado3;

        //Int32.TryParse(longitud1, out lado1);
        //Int32.TryParse(longitud2, out lado2);
        //Int32.TryParse(longitud3, out lado3);

        //Console.WriteLine(nuevaguia.ClasificacionTriangulo(lado1, lado2, lado3));
        //Console.WriteLine($"El perimetro del triangulo es: {nuevaguia.PerimetroTriangulo(lado1, lado2, lado3)}");
        //Console.WriteLine("El area del triangulo es: {0:N2}", nuevaguia.AreaTriangulo(lado1, lado2, lado3));
        ////Console.WriteLine(nuevaguia.PerimetroTriangulo(lado1, lado2, lado3));
        ////Console.WriteLine(nuevaguia.AreaTriangulo(lado1, lado2, lado3));

        ////ejercicio7
        //Console.WriteLine(nuevaguia.Desglose(1723));

        ////ejercicio8
        //Console.WriteLine("Ingresar N:");
        //option = Console.ReadLine();
        //Int32.TryParse(option, out num);
        //Console.WriteLine(nuevaguia.UnoAN(num));

        ////ejercicio9
        //nuevaguia.Suma15Numeros();

        ////ejercicio10
        //nuevaguia.MultiploDeTres();

        ////ejercicio11
        //nuevaguia.Password();

        ////ejercicio12
        //nuevaguia.PasswordTresIntentos();

        ////ejercicios13
        //nuevaguia.Adivinanza();

        ////ejercicio14
        //nuevaguia.AdivinanzaConPista();

        ////ejercicio15
        //nuevaguia.SumaNNumeros();
        #endregion

        #region clase cuadrado
        Cuadrado unCuadrado = new Cuadrado(4);
        Console.WriteLine($"El area del cuadrado es: {unCuadrado.CalcularArea()}");
        #endregion

        #region clase persona
        DateTime fecha = new DateTime(2000, 12, 31);
        Persona unaPersona = new Persona("Juan","Perez",fecha);
        Console.WriteLine(unaPersona.NombreCompleto());
        Console.WriteLine(unaPersona.CalcularEdad());
        #endregion

        #region clase auto
        Auto unAuto = new Auto("Ford", "Ranger", "Negro",5);
        Console.WriteLine(unAuto.Encendido);
        unAuto.Encender();
        Console.WriteLine(unAuto.Encendido);
        #endregion

        #region clase estudiante
        Persona autor1 = new Persona("pepe", "sand", fecha);
        Libro libro1 = new Libro("el libro", autor1, 55);
        Libro libro2 = new Libro("el libro2", autor1, 45);
        Libro libro3 = new Libro("el libro3", autor1, 35);
        Libro libro4 = new Libro("el libro4", autor1, 70);
        libro1.WasRead= true;
        libro3.WasRead= true;
        List<Libro> listaLibros = new List<Libro>() { libro1,libro2,libro3,libro4};
        Estudiante estudiante1 = new Estudiante("Hector", "Hernandez", fecha, listaLibros);
        Console.WriteLine(estudiante1.CantidadLibrosSinLeer());
        Console.WriteLine(estudiante1.PaginasLeidas());
        estudiante1.Leidos().ForEach(l => Console.WriteLine(l.Nombre));
        #endregion
    }
}