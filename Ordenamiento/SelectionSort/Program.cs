using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas_1;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Selection Sort
            Lista_Ligada lista = new Lista_Ligada();
            lista.Agregar(4);
            lista.Agregar(5);
            lista.Agregar(8);
            lista.Agregar(2);
            lista.Agregar(9);
            lista.Agregar(3);
            lista.Agregar(1);
            lista.Agregar(8);
            lista.Agregar(9);
            lista.Agregar(2);
            lista.Agregar(7);
            lista.Agregar(5);
            lista.Transversa();
            // Datos necesarios
            int cantidad = lista.getSize() + 1;
            int iMenor = 0;
            int temporal = 0;
            // Ascendente
            Console.WriteLine("Lista Ordenada Ascendente");
            for (int i = 0; i < cantidad - 1; i++)
            {
                //El indice menor es la posición actual desde donde comenzamos
                iMenor = i;
                // Encontramos el nuevo indice del menor
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (lista[j] < lista[iMenor])
                    {
                        iMenor = j;
                    }
                }
                temporal = (int)lista[i];
                lista[i] = lista[iMenor];
                lista[iMenor] = temporal;
            }
            lista.Transversa();
            // Descendente
            Console.WriteLine("Lista Ordenada Descendente");
            for (int i = 1; i < cantidad; i++)
            {
                //El indice menor es la posición actual desde donde comenzamos
                iMenor = i;
                // Encontramos el nuevo indice del menor
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (lista[j] > lista[iMenor])
                    {
                        iMenor = j;
                    }
                }
                temporal = (int)lista[i];
                lista[i] = lista[iMenor];
                lista[iMenor] = temporal;
            }
            lista.Transversa();

            // Ejercicio Programando el orden con 2 listas...
            Lista_Ligada listaResultado = new Lista_Ligada();
            int cantidadLista = lista.getSize() + 1;
            int indiceBorrar = 0;
            int menor = 0;
            int mayor = (int)lista[1];

            for (int i = 1; i < cantidadLista; i++)
            {
                menor = mayor;
                for (int j = 1; j < cantidadLista; j++)
                {
                    // Mientras busco el menor, voy buscando el mayor disponible para luego igualarlo
                    // Para luego hallar menores en base al mayor...
                    if (lista[i] > mayor && lista[i] > 0)
                    {
                        mayor = (int)lista[i];
                    }
                    // Recorro la lista y encuentro el menor
                    if (lista[j] < menor && lista[j] > 0)
                    {
                        menor = (int)lista[j];
                        indiceBorrar = j;
                    }
                }
                lista[indiceBorrar] = 0;
                listaResultado.Agregar(menor);
            }
            Console.WriteLine("Selection Sort 2 Listas");
            listaResultado.Transversa();
        }
    }
}
