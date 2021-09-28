using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança");
            }
            else if (idade > 11 && idade <= 18)
            {
                Console.WriteLine("Você é um adolescente");
            }
            else if (idade > 18 && idade <= 30)
            {
                Console.WriteLine("Você é um jovem adulto");
            }
            else if (idade > 30 && idade <= 59)
            {
                Console.WriteLine("Você é um adulto");
            }
            else if (idade >= 60)
            {
                Console.WriteLine("Você está na melhor idade!");
            }
            Console.ReadLine();
        }
    }
}
