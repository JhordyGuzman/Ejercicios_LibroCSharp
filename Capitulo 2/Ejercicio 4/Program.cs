using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, resultado = 0;
            string v = "";
 
            Console.WriteLine("Ingrese el grado centigrado");
            v = Console.ReadLine();
            a = Convert.ToSingle(v);
 
            resultado = (a * 9 / 5) + 32;
            Console.WriteLine("El Grado en Fahrenheit Es: " + resultado); 
        }
    }
}
