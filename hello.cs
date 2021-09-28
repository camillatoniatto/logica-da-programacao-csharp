using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opa, bão?");
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.Write("Seu nome é: ");
            Console.Write(nome);
            Console.ReadLine();
        }
    }
}
