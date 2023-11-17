using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 23, 12, 54, 21, 65, 34, 87, 65, 98, 76, 34, 23, 12, 1, 4, 1, 98, 2 };
            Console.WriteLine("---Lista Desordenada---");
            mostrar(lista);
            // For para ordenar
            for (int i = 1; i < lista.Length; i++)
            {
                for (int j = 0; j < lista.Length - i; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
            // Fin For
            Console.WriteLine("---Lista Ordenada---");
            mostrar(lista);
        }

        private static void mostrar(int[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
