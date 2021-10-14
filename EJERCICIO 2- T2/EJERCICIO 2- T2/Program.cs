using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2__T2
{
    class Program
    {
        //Autor: Juan Diego Andrade Tubay       Fecha: 12/10/2021
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa que lea un número e indique si es par o impar-----");
            Console.WriteLine("Ingrese el número");
            string numero = Console.ReadLine();
            int num = int.Parse(numero);
            if (num % 2 == 0)
                Console.WriteLine("El numero {0} es par",num);
            else
                Console.WriteLine("El numero {0} es impar", num);
            Console.Read();
        }
    }
}
