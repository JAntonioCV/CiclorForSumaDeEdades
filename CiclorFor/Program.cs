using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclorFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables 
            int sumaEdad = 0;
            int promedioEdad = 0;

            Console.WriteLine("Ingrese la cantidad de personas: ");
            int cantidadPersonas = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < cantidadPersonas; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona {0}",i+1);
                sumaEdad += int.Parse(Console.ReadLine());

                //int edad = int.Parse(Console.ReadLine());

                //sumaEdad = sumaEdad + edad;
                //sumaEdad += edad;
            }

            Console.WriteLine("La suma de las edades es: " + sumaEdad);
            Console.WriteLine("El promedio es: " + sumaEdad/cantidadPersonas);


            Console.ReadKey();
        }
    }
}
