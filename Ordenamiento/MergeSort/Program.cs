using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas_1;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista_Ligada lista = new Lista_Ligada();
            lista.Agregar(77);
            lista.Agregar(34);
            lista.Agregar(68);
            lista.Agregar(24);
            lista.Agregar(75);
            lista.Transversa();

            Lista_Ligada mergeSort = new Lista_Ligada();
            mergeSort = MergeSortMethod(lista);
            mergeSort.Transversa();
            //Lista_Ligada izq = new Lista_Ligada();
            //izq.Agregar(1);
            //izq.Agregar(3);
            //izq.Agregar(5);
            //izq.Agregar(7);
            //izq.Transversa();

            //Lista_Ligada der = new Lista_Ligada();
            //der.Agregar(2);
            //der.Agregar(4);
            //der.Agregar(6);
            //der.Agregar(8);
            //der.Agregar(10);
            //der.Agregar(12);
            //der.Transversa();

            //Lista_Ligada merged = Merge(izq, der);
            //merged.Transversa();
        }

        private static Lista_Ligada MergeSortMethod(Lista_Ligada lista)
        {
            // Cantidad de elementos en la lista.
            int cantidad = lista.getSize() + 1;
            // Caso base, una lista de un solo elemento ya está ordenada
            if (cantidad < 3)
            {
                return lista;
            }

            //Obtenemos el punto medio de la lista
            int mitad = cantidad / 2;

            Lista_Ligada left = new Lista_Ligada();
            Lista_Ligada der = new Lista_Ligada();

            // Adicionamos a la izquierda desde el inicio hasta antes de la mitad
            for (int i = 1; i <= mitad; i++)
            {
                left.Agregar((int)lista[i]);
            }
            for (int i = mitad + 1; i < cantidad; i++)
            {
                der.Agregar((int)lista[i]);
            }

            // Casos Inductivos
            // Hacemos el MergeSort de las listas izquierda y derecha
            Lista_Ligada tempoLeft = MergeSortMethod(left);
            Lista_Ligada tempoRight = MergeSortMethod(der);

            // Hacemos el merge de lo que nos regresa el caso inductivo
            Lista_Ligada ordenado = Merge(tempoLeft, tempoRight);

            // Regresamos la lista ordenada
            return ordenado;
        }

        private static Lista_Ligada Merge(Lista_Ligada izq, Lista_Ligada der)
        {
            // Lista dónde se unen los valores
            Lista_Ligada union = new Lista_Ligada();
            // Indices de cada lista.
            int indexIzq = 1;
            int indexDer = 1;
            // Cantidad de elementos.
            int cantIzq = izq.getSize() + 1;
            int cantDer = der.getSize() + 1;

            // Recorremos los elementos mientras las 2 listas tengan elementos para procesar.
            while (indexIzq < cantIzq && indexDer < cantDer)
            {
                // Si el de la izquierda es menor o igual adicionamos el de la izquierda.
                if (izq[indexIzq] <= der[indexDer])
                {
                    union.Agregar((int)izq[indexIzq]);
                    // Avanzamos el indice izquierdo.
                    indexIzq++;
                }
                else // Si el de la derecha es menor, adicionamos el de la derecha.
                {
                    union.Agregar((int)der[indexDer]);
                    // Avanzamos el indice derecho.
                    indexDer++;
                }
            }

            // Si en dado caso han sobrado elementos en la lista izquierda los agregaremos
            while (indexIzq < cantIzq)
            {
                union.Agregar((int)izq[indexIzq]);
                indexIzq++;
            }
            // Si en dado caso han sobrado elementos en la lista derecha los agregaremos
            while (indexDer < cantDer)
            {
                union.Agregar((int)der[indexDer]);
                indexDer++;
            }

            return union;
        }
    }
}
