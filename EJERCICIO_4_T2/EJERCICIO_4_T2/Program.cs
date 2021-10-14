using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_4_T2
{
    class Program
    {
        //Autor: Juan Diego Andrade Tubay       Fecha: 12/10/2021
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa que lea números decimales indefinidamente hasta que llegue el número 0-----");
            Console.WriteLine();

            Console.WriteLine("Ingrese un número diferente de cero para continuar el programa, caso contrario dejará de ejecutarse");
            int conta = 0;
            double numero = 0;

            do
            {
                string imput = Console.ReadLine();
                numero = double.Parse(imput);
                conta++;
            } while (numero!=0);
            Console.WriteLine("Pasaron {0} números hasta finalizar el programa", conta);
            Console.Read();
        }
    }
}
