using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float cambio = 0, dolar = 0, total = 0;
            string CB = "";
            string DO = "";

            Console.Write("Ingrese el Cambio del Dia: ");
            CB = Console.ReadLine();
            cambio = Convert.ToSingle(CB);

            Console.Write("Ingrese la cantidad de Dolares: ");
            DO = Console.ReadLine();
            dolar = Convert.ToSingle(DO);

            total = cambio * dolar;

            Console.WriteLine(total + " Euros");
        }
    }
}
