using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos_3_DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIOS PRACTICOS #3\n");

            Console.WriteLine("Problema 1\n");
            Ejercicios ejercicio1 = new Ejercicios();
            ejercicio1.Arreglo3x3();
            Console.WriteLine("\n");

            Console.WriteLine("Problema 2.\n");
            Ejercicios ejercicio2 = new Ejercicios();
            ejercicio2.Colores();
            Console.WriteLine("\n");

            Console.WriteLine("Problema 3.\n");
            Ejercicios ejercicio3 = new Ejercicios();
            ejercicio3.SumarArreglos();
            Console.WriteLine("\n");

            Console.WriteLine("Problema 4.\n");
            Ejercicios ejercicio4 = new Ejercicios();
            ejercicio4.Letras();
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
