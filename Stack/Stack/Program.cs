using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            pila.Push('a');
            pila.Push('b');
            pila.Push('c');
            pila.Push('d');
            pila.Transversa();

            Console.WriteLine(pila.Pop());
            pila.Transversa();

            Console.WriteLine(pila.Peek());
            pila.Transversa();
        }
    }
}
