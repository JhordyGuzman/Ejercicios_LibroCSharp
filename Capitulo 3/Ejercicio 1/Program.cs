using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero = 0;
            string N = "";

            Console.Write("Ingrese un numero: ");
            N = Console.ReadLine();
            numero = Convert.ToSingle(N);

            if(numero % 2 == 0)
            {
                Console.WriteLine("El numero " + numero + " es par.\n\n");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " es impar.\n\n");
            }
        }
    }
}
