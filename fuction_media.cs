using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva sua primeira nota: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva sua segunda nota: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Escreva sua terceira nota: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("Escreva sua quarta nota: ");
            int n4 = int.Parse(Console.ReadLine());

            float media = Media(n1, n2, n3, n4);
            Console.WriteLine("A sua média é: " + media);

            Console.ReadLine();
        }
        static float Media(int a, int b, int c, int d)
        {
            float media = (a + b + c + d) / 4;     
            return media;            
        }
    }
}