using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;
namespace Infix_to_Postfix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            Stack.Stack pila = new Stack.Stack();
            string exp = "5+6*7-8*9";
            string res = "";
            // Recorremos caracter por caracter
            foreach (char item in exp)
            {
                if (char.IsDigit(item))
                {
                    res += item;
                }
                else
                {
                    while (pila.Cantidad() > 0 && Precedencia(pila.Peek(), item))
                    {
                        res += pila.Pop();
                    }
                    pila.Push(item);
                }
            }
            int restantes = pila.Cantidad();
            if (restantes > 0)
            {
                while (restantes != 0)
                {
                    res += pila.Pop();
                    restantes--;
                }
            }
            Console.WriteLine(res);
        }

        private static bool Precedencia(char Pila, char Actual)
        {
            if (Actual == '*' | Actual == '/')
            {
                if (Pila == '+' | Pila == '-')
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (Actual == '+' | Actual == '-')
            {
                if (Pila == '*' | Pila == '/' | Pila == '+' | Pila == '-')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
