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
            Console.WriteLine("-----Programa que escriba todos los múltiplos de 7 del número 1 al 1000 -----");
            Console.WriteLine();
            int conta = 0;
            Console.WriteLine("Los múltiplos son: ");
            for (int mult = 0; mult <= 1000; mult += 7)
            {
                Console.WriteLine("7 * "+conta+" = "+mult);
                conta++;
            }
            Console.WriteLine("--Programa finalizado--");
            Console.Read();
        }
    }
}