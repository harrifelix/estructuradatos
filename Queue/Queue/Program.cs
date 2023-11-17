using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola fila = new Cola();
            fila.Enqueue(5);
            fila.Enqueue(3);
            fila.Enqueue(7);
            fila.Enqueue(1);
            fila.Transversa();
            // Probando Dequeue
            Console.WriteLine("El valor adquirido {0} ", fila.Dequeue());
            fila.Transversa();
            fila.Enqueue(8);
            // Probando Peek
            Console.WriteLine("El valor obsevado {0} ", fila.Peek());
            fila.Transversa();
        }
    }
}
