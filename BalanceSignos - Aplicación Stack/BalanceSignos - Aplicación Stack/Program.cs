using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSignos___Aplicación_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresion;
            char s = ' ';
            Pila stack = new Pila();
            // Pedimos la expresión a evaluar
            Console.WriteLine("Dame la expresion a evaluar");
            expresion = Console.ReadLine();

            foreach (char c in expresion)
            {
                // Verificamos que sea simbolo de apertura
                if (c == '(' || c == '{' || c == '[')
                {
                    // Lo colocamos en el stack
                    stack.Push(c);
                }
                // Verificamos que sea símbolo de cierre
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.isEmpty())
                    {
                        Console.WriteLine("---Exceso de símbolos de cierre---");
                    }else
	                {
                        // Obtenemos el caracter correspondiente
                        s = stack.Pop();
                        // Verificamos que se tenga coincidencia
                        if (s=='(' && c!= ')')
                        {
                            Console.WriteLine("Se esperaba )");
                        }
                        if (s == '{' && c != '}')
                        {
                            Console.WriteLine("Se esperaba }");
                        }
                        if (s == '[' && c != ']')
                        {
                            Console.WriteLine("Se esperaba ]");
                        } 
	                }
                }
            }
            if (!stack.isEmpty())
            {
                Console.WriteLine("---Exceso de elementos de Apertura---");
            }
        }
    }
}
