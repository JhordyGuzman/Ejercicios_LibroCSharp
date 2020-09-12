using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
           float dia = 0;
           string D = "";

            Console.Write("Ingrese un numero entre el 1 y el 7: ");
            D = Console.ReadLine();
            dia = Convert.ToSingle(D);

            if(dia == 1)
            {
                Console.Write("Lunes.\n");
            }
            else if (dia == 2)
            {
                Console.Write("Martes.\n");
            }
            else if(dia == 3)
            {
                Console.Write("Miercoles.\n");
            }
            else if(dia == 4)
            {
                Console.Write("Jueves.\n");
            }
            else if(dia == 5)
            {
                Console.Write("Viernes.\n");
            }
            else if(dia == 6)
            {
                Console.Write("Sabado.\n");
            }
            else if(dia == 7)
            {
                Console.Write("Domingo.\n");
            }
            else if(dia >=8)
            {
                Console.Write("\nDebe ingresar un numero entre el 1 y el 7 usted ingreso el " + D + ".\n");
            }
            else if(dia <= 0)
            {
                Console.Write("\nDebe ingresar un numero entre el 1 y el 7 usted ingreso el " + D + ".\n");
            }
        }
    }
}
