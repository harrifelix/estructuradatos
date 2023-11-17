using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas_1;

namespace QuickSort
{
    class Program
    {
        private static Lista_Ligada lista1 = new Lista_Ligada();
        static void Main(string[] args)
        {
            
            lista1.Agregar(73489);
            lista1.Agregar(12978);
            lista1.Agregar(48);
            lista1.Agregar(43);
            lista1.Agregar(1092);
            lista1.Transversa();

            quickSort(1, lista1.getSize());
            lista1.Transversa();
        }

        private static void swap(int i1, int i2)
        {
            int temp = (int)lista1[i1];
            lista1[i1] = lista1[i2];
            lista1[i2] = temp;
        }

        public static int Particion(int pInit, int pFin)
        {
            int pivote = 0;
            int iPivote = 0;

            // Seleccionamos el ultimo como pivote
            pivote = (int)lista1[pFin];
            // Ponemos el indice de pivote con el indice de inicio
            iPivote = pInit;
            // Recorremos la lista en el indice n es menor o igual al pivote
            for (int i = pInit; i < pFin; i++)
            {
                // Si el elemento en el indice es menor o igual al pivote
                if (lista1[i] <= pivote)
                {
                    swap(i, iPivote);
                    // Incrementamos el indice del pivote
                    iPivote++;
                }
            }
            // Hacemos el swap final para colocar el pivote donde corresponde
            swap(iPivote, pFin);
            // Regresamos el indice del pivote
            return iPivote;
        }

        public static void quickSort(int pInicio, int pFin)
        {
            int iPivote = 0;
            // Caso base, un elemento o fragmento inválido
            if (pInicio >= pFin) { return; }
            // Obtenemos el indice del pivote para el fragmento con el que trabajamos
            iPivote = Particion(pInicio, pFin);
            // Casos inductivos
            quickSort(pInicio, iPivote - 1); // Fragmento a la izquierda del pivote
            quickSort(iPivote + 1, pFin); // Fragmento a la derecha del pivote
        }
    }
}
