using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas_1;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista_Ligada lista = new Lista_Ligada();
            lista.Agregar(5);
            lista.Agregar(2);
            lista.Agregar(4);
            lista.Agregar(8);
            lista.Transversa();
            Console.WriteLine(lista[1]);
            Console.WriteLine(lista[2]);
            Console.WriteLine(lista[3]);
            Console.WriteLine(lista[4]);
            //Insertion Sort
            int cantidad = lista.getSize() + 1;
            int indexAgujero = 0;
            int dato = 0;
            // Ascendente
            //Recorremos los elementos
            for (int i = 0; i < cantidad; i++)
            {
                //Obtenemos el dato
                dato = (int)lista[i];
                //Indicamos la posición del agujero
                indexAgujero = i;
                //Recorremos los elementos hacia el agujero
                while (indexAgujero > 0 && lista[indexAgujero - 1] > dato)
                {
                    lista[indexAgujero] = lista[indexAgujero - 1];
                    indexAgujero -= 1;
                }
                //Le colocamos al agujero el dato correspondiente
                lista[indexAgujero] = dato;
                //lista.Transversa();
            }
            //Mostrar lista ordenada
            Console.WriteLine("Lista Ordenada");
            lista.Transversa();

            // Descendente
            //Insertion Sort
            int size = lista.getSize() + 1;
            int indiceHole = 0;
            int numerito = 0;
            // Ascendente
            //Recorremos los elementos
            for (int i = 2; i < size; i++)
            {
                //Obtenemos el dato
                numerito = (int)lista[i];
                //Indicamos la posición del agujero
                indiceHole = i;
                //Recorremos los elementos hacia el agujero
                while (indiceHole > 1 && lista[indiceHole - 1] < numerito)
                {
                    lista[indiceHole] = lista[indiceHole - 1];
                    indiceHole -= 1;
                }
                //Le colocamos al agujero el dato correspondiente
                lista[indiceHole] = numerito;
            }
            //Mostrar lista ordenada
            Console.WriteLine("Lista Ordenada");
            lista.Transversa();
        }
    }
}
