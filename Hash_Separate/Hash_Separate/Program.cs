using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Separate
{
    class Program
    {
        // Cantidad de celdas en la tabla
        private static int size = 7;
        private static Lista[] tabla;

        static void Main(string[] args)
        {
            // Necesitamos un arreglo de listas ligadas para crear la tabla
            tabla = new Lista[size];
            // Inicializamos la tabla
            for (int i = 0; i < size; i++) { tabla[i] = new Lista(); }
            Mostrar();
            Console.WriteLine("----");
            Insertar(57, "Hola");
            Insertar(45, "Manzana");
            Insertar(42, "Pera");
            Insertar(83, "Azul");
            Insertar(30, "Rojo");
            Insertar(94, "C#");
            Insertar(73, "C++");
            Insertar(97, "Saludos");
            Mostrar();
            Console.WriteLine("----");
        }

        public static int Hash(int Llave) { return Llave % size; }

        private static void Insertar(int Llave, string Valor){ tabla[Hash(Llave)].Adicionar(Llave, Valor); }

        private static void Mostrar()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("({0})", i);
                tabla[i].Transversa();
                Console.WriteLine();
            }
        }
    }
}
