using System;
using System.Globalization;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {

            int a , b , c;
            double x1, x2 , delta, raiz;

            Console.WriteLine("================================================");
            Console.WriteLine("Bora resolver uma formula de bhaskara!");
            Console.Write("\nDigite os coeficientes do polinômio na ordem de expoente decrescente: ");
            Console.WriteLine("Exemplo: 4 3 -2 => 4x² + 3x - 2");
            Console.Write("\nValor de x²: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Valor de x: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Valor do Coeficiente Constante: ");
            c = int.Parse(Console.ReadLine());


           delta = (b*b) - 4*a*c;
           raiz = Math.Sqrt(delta);
           x1 = (b - raiz) / (2 * a) *-1;
           x2 = (b + raiz) / (2 * a) *-1;

           if (delta > 0)
            {
              Console.WriteLine("Resultado de x': " + x1.ToString("F8"));
              Console.WriteLine("Resultado de x'': " + x2.ToString("F8"));
            }
           else if (delta == 0)
           {
               Console.WriteLine("Resultado de x': " + x1.ToString("F8"));
           }

           else
           {
               Console.WriteLine("Nao existe raizes reais!");
           }

        }
    }
}
