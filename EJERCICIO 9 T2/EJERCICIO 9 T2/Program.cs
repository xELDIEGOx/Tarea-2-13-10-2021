using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_9_T2
{
    class Program
    {
        //Autor: Juan Diego Andrade Tubay       Fecha: 12/10/2021
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa que lea una serie de números y calcule su promedio hasta que aparezca el cero-----");
            Console.WriteLine();

            int conta = 0;
            double promedio = 0, suma = 0,numero = 0;
            do
            {
                conta++;
                Console.WriteLine("Ingrese el {0} número", conta);
                numero = int.Parse(Console.ReadLine());
                suma += numero;
            } while (numero != 0);
            promedio = suma / conta;
            Console.WriteLine("El promedio de los números ingresados es: {0}", promedio);
            Console.Read();
        }
    }
}
