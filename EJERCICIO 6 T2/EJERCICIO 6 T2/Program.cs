using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_6_T2
{
    class Program
    {
        //Autor: Juan Diego Andrade Tubay       Fecha: 12/10/2021
        static void Main(string[] args)
        { 
            Console.WriteLine("-----Programa que lea números indefinidamente y se sumen hasta que se typee un cero-----");
            Console.WriteLine(); 

            int conta = 1, numero = 0, suma = 0;

            do
            { 
                Console.WriteLine("Ingrese el {0} número", conta);
                string imput = Console.ReadLine();
                numero = int.Parse(imput);
                conta++;
                suma += numero;
            } while (numero != 0);

            Console.WriteLine("La suma de los números ingresados hasta encontrar el cero es {0}", suma);
            Console.Read();
        } 
    }
}
