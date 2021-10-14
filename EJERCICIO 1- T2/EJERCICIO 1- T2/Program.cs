using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1__T2
{
    class Program
    {
        // Autor: Juan Diego Andrade     Fecha: 12/10/2021
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa que lea el mayor de dos números-----");
            Console.WriteLine("Ingrese el primer número");
            string numero1 = Console.ReadLine();
            Console.WriteLine("Ingrese el primer número");
            string numero2 = Console.ReadLine();
            int num1 = int.Parse(numero1);
            int num2 = int.Parse(numero2);

            if (num1 > num2)
                Console.WriteLine("Primer número ingresado mayor {0}: ",num1);
            else
                Console.WriteLine("Segundo número ingresado mayor {0}: ", num2);

            Console.Read();
        }
    }
}
