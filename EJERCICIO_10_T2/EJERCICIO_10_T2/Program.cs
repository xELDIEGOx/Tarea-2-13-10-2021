using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_10_T2
{
    class Program
    {
        //Autor: Juan Diego Andrade Tubay       Fecha: 12/10/2021
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa que lea un número entero por teclado y " +
                "muestre por pantalla el proceso del cálculo de su factorial.-----");
            Console.WriteLine();

            int conta = 0, factorial = 0, calculo = 1;

            Console.WriteLine("Ingrese el número factorial a calcular");
            factorial = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(factorial+" ! es igual a: ");
            while (conta < factorial)
            {
                conta++;
                Console.WriteLine("-"+calculo + " * " + conta);
                calculo *= conta;
            } 
            Console.WriteLine("El cálculo del factorial {0} es: {1}", factorial, calculo);
            Console.Read();
        }
    }
}
