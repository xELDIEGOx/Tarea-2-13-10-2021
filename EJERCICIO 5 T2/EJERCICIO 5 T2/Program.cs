using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_5_T2
{
    class Program
    {
        //Autor: Juan Diego Andrade Tubay       Fecha: 12/10/2021
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa que lea exactamente 5 números y luego escriba la suma de todos ellos-----");
            Console.WriteLine();

            int conta = 1, numero = 0, suma = 0;

            do
            {
                Console.WriteLine("Ingrese el {0} número",conta);
                string imput = Console.ReadLine();
                numero = int.Parse(imput);
                conta++;
                suma += numero;
            } while (conta <=5);
            Console.WriteLine("La suma de los números ingresados es {0}", suma);
            Console.Read();
        }
    }
}
