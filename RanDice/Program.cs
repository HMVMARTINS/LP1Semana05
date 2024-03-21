using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length !=2)
            {
                Console.WriteLine("Uso: dotnet run --project RanDice -- <número_de_dados> <semente>");
                return;
            }

            if (!int.TryParse(args[0], out int numDados) || numDados <= 0)
            {
                Console.WriteLine("O número de dados deve ser um número inteiro positivo.");
                return;
            }

            if (!int.TryParse(args[1], out int seed))
            {
                Console.WriteLine("A semente deve ser um número inteiro.");
                return;
            }

            //Inicia o gerador de números aleatórios com a semente fornecida
            Random random = new Random(seed);

            int soma = 0;
            for (int i = 0; i < numDados; i++)
            {
                //Gera um número aleatório entre 1 e 6 para cada dado
                int valorDado = random.Next(1,7);
                Console.WriteLine("Dado {0}: {1}", i + 1, valorDado);
                soma += valorDado;
            }

            Console.WriteLine("Soma dos valores: " + soma);
        }
    }
}
