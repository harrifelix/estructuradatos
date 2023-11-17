using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;

namespace Evaluacion_Expresiones
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] resultado;
            // Evaluación de Postfix
            Stack.Stack pila = new Stack.Stack();
            int n = 0;
            int a = 0;
            int b = 0;
            // -+3*52*73
            // 352*+73*-
            String expresion = "33 5 2 * + 7 3 * - 100 *";
            // Para Postfix primero b luego a en pila.Pop();
            // Para PreFix primero a luego b en pila.Pop();
            resultado = expresion.Split(' ');
            try
            {
                foreach (string item in resultado)
                {
                    if (item == "*" || item == "/" || item == "+" || item == "-")
                    {
                        b = pila.Pop();
                        a = pila.Pop();
                        switch (item)
                        {
                            case "+":
                                n = a + b;
                                break;
                            case "-":
                                n = a - b;
                                break;
                            case "*":
                                n = a * b;
                                break;
                            case "/":
                                n = a / b;
                                break;
                            default:
                                break;
                        }
                        pila.Push(Convert.ToInt32(n));
                    }
                    else if (Convert.ToInt32(item) >= 0)
                    {
                        pila.Push(Convert.ToInt32((item)));
                    }
                }
                if (pila.Cantidad() == 1)
                {
                    Console.Write("Resultado de la Expresión {0} es = ", expresion);
                    pila.Transversa();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Hay un error con la expresión, verifica que cumpla la norma PostFix\nQue contenga espacios entre operadores.\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            
        }
    }
}
