using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_3_T3
{
    class Program
    {
        //Autor: Juan Diego Andrade Tubay       Fecha: 12/10/2021
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa que lea tres números y mostrar por pantalla el mayor de los tres-----");
            Console.WriteLine("Ingrese el primer número");
            string numero1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número");
            string numero2 = Console.ReadLine();
            Console.WriteLine("Ingrese el tercer número");
            string numero3 = Console.ReadLine();
            int num1 = int.Parse(numero1);
            int num2 = int.Parse(numero2);
            int num3 = int.Parse(numero3);
            if (num1 > num2 && num1 > num3)
                Console.WriteLine("El número {0} es mayor que el {1} y {2} número",num1,num2,num3);
            else
                if (num2 > num1 && num2 > num3)
                    Console.WriteLine("El número {0} es mayor que el {1} y {2} número", num2, num1, num3);
                else
                    Console.WriteLine("El número {0} es mayor que el {1} y {2} número", num3, num1, num2);
            Console.Read();
        }
    }
}
