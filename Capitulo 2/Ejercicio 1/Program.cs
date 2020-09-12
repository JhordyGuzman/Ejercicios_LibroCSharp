using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string CL = "";
            string TL = "";
            float cantidadLados = 0, tamañoLados = 0, Perimetro = 0;

            Console.Write("ingrese la cantidad de lados: ");
            CL = Console.ReadLine();
            cantidadLados = Convert.ToSingle(CL);

            Console.Write("ingrese el tamaño de un lado: ");
            TL = Console.ReadLine();
            tamañoLados = Convert.ToSingle(TL);

            Perimetro = cantidadLados * tamañoLados;
            Console.Write("\nEl Perimetro es: ");
            Console.Write(Perimetro + "\n\n\n");
        }
    }
}
