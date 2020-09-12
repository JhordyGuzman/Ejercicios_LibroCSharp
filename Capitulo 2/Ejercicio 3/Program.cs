using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            float pi = 3.1416f, resultado = 0;
            int a = 0; 
            string v = "";

            Console.WriteLine("Ingrese el Grado");   
            v = Console.ReadLine();
            a = Convert.ToInt32(v);
 
            resultado = a * (pi / 180);
 
            Console.WriteLine("La Conversion de Grado a Radian Es: " + resultado); 
        }
    }
}
