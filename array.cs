using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] cores = new string[5] {
                "Amarelo", 
                "Azul", 
                "Vermelho", 
                "Rosa", 
                "Roxo"
            };
            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine(cores[i]);
            }

            for (i = 0; i < cores.Length; i++) //verifica o tamanho do array e descobre o numero máximo
            {
                Console.WriteLine(cores[i]);
            }

            Console.ReadLine();
        }
    }
}
