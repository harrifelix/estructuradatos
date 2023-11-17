using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci(24));
        }

        private static int fibonacci(int indice)
        {
            int r = 0;

            //Caso Inductivo
            if (indice > 1)
            {
                r = fibonacci(indice - 1) + fibonacci(indice - 2);
            }

            //Caso Base
            if (indice <= 1)
            {
                r = 1;
            }

            return r;
        }
    }
}
