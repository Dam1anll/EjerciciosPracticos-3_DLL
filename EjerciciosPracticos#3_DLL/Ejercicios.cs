using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos_3_DLL
{
    internal class Ejercicios
    {
        public void Arreglo3x3()
        {
            int[,] arregloBi = new int[3, 3];

            int num = 1;

            for (int arregloFila = 0; arregloFila < 3; arregloFila++)
            {
                for (int arregloColumna = 0; arregloColumna < 3; arregloColumna++)
                {
                    arregloBi[arregloFila, arregloColumna] = num;
                    num++;
                }
            }

            for (int arregloFila = 0; arregloFila < 3; arregloFila++)
            {
                for (int arregloColumna = 0; arregloColumna < 3; arregloColumna++)
                {
                    Console.Write(arregloBi[arregloFila, arregloColumna] + " ");
                }

                Console.WriteLine();
            }
        }

        public void Colores()
        {
            string[,] color = new string[2, 2];

            color[0, 0] = "Rojo";
            color[0, 1] = "Verde";
            color[1, 0] = "Azul";
            color[1, 1] = "Amarillo";

            for (int arregloFila = 0; arregloFila < 2; arregloFila++)
            {
                for (int arregloColumna = 0; arregloColumna < 2; arregloColumna++)
                {
                    Console.Write(color[arregloFila, arregloColumna] + " ");
                }

                Console.WriteLine(); 
            }
        }

        public void SumarArreglos()
        {
     
            double[,] num = new double[4, 3];
            double valor = 1.0;

            for (int arregloFila = 0; arregloFila < 4; arregloFila++)
            {
                for (int arregloColumna = 0; arregloColumna < 3; arregloColumna++)
                {
                    num[arregloFila, arregloColumna] = valor;
                    valor += 0.5; 
                }
            }

            for (int arregloFila = 0; arregloFila < 4; arregloFila++)
            {
                for (int arregloColumna = 0; arregloColumna < 3; arregloColumna++)
                {
                    Console.Write(num[arregloFila, arregloColumna] + " ");
                }
                Console.WriteLine(); 
            }

            double suma = 0.0;
            for (int arregloFila = 0; arregloFila < 4; arregloFila++)
            {
                for (int arregloColumna = 0; arregloColumna < 3; arregloColumna++)
                {
                    suma += num[arregloFila, arregloColumna];
                }
            }

            Console.WriteLine("La suma del arreglo es: " + suma);

        }

        public void Letras()
        {
            char[,] letras = new char[2, 4];
            char letraUno = 'A';

            for (int arregloFila = 0; arregloFila < 2; arregloFila++)
            {
                for (int arregloColumna = 0; arregloColumna < 4; arregloColumna++)
                {
                    letras[arregloFila, arregloColumna] = letraUno;
                    letraUno++;
                }
            }

            for (int arregloFila = 0; arregloFila < 2; arregloFila++)
            {
                for (int arregloColumna = 0; arregloColumna < 4; arregloColumna++)
                {
                    Console.Write(letras[arregloFila, arregloColumna] + "\t"); 
                }
                Console.WriteLine(); 
            }
        }
    }
}
