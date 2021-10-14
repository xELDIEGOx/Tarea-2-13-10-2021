using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EJERCICIO_7_T2
{
    class Program
    {
        //Autor: Juan Diego Andrade Tubay       Fecha: 12/10/2021
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa que identifique el tipo de triángulo segun su ingreso de variables-----");
            Console.WriteLine();
            int conta = 0;
            double lado1, lado2, lado3;
            string respuesta = " ";
            do
            {
                Console.WriteLine("Ingrese el lado número 1");
                lado1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el lado número 2");
                lado2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el lado número 3");
                lado3 = int.Parse(Console.ReadLine());
                if (lado1 == lado2 && lado1 == lado3)
                    Console.WriteLine("El triángulo ingresado es un equilatero");
                else
                    if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                        Console.WriteLine("El triángulo ingresado es un escaleno");
                    else
                        Console.WriteLine("El triángulo ingresado es un Isóceles");
                conta++;
                Console.WriteLine();
                Console.WriteLine("Desea salir del programa ?");
                Console.WriteLine("Ingrese S (SI) O N (NO) ");
                respuesta = Console.ReadLine();
            } while (respuesta !="S"); 
            Console.Read();
        }
    }
}
