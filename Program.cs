using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos las matrices
            int[,] matrizA = new int[3, 3];//ESTAS SON LAS DIMENSIONES DE LA MATRIZ
            int[,] matrizB = new int[3, 3];// la coma (,) se utiliza para separar los elementos de cada fila.
                                           // Por ejemplo, el elemento A[0,0] se representa
                                           // como el primer elemento del primer arreglo del arreglo A

            // Solicitamos los datos de la matriz A
            Console.WriteLine("Ingrese los datos de la matriz A:");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    matrizA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Solicitamos los datos de la matriz B
            Console.WriteLine("Ingrese los datos de la matriz B:");
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write("B[{0},{1}] = ", i, j);
                    matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Mostramos los datos de la matriz A
            Console.WriteLine("Matriz A:");
            for (int i = 0; i < matrizA.GetLength(0); i++)//GetLength() se utiliza para obtener el tamaño de una matriz.
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrizA[i, j]);
                }
                Console.WriteLine();
            }

            // Mostramos los datos de la matriz B
            Console.WriteLine("Matriz B:");
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrizB[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

