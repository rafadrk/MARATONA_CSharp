using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Maratona  - numeros pares");
        Console.WriteLine();

        int N, Pares;

        Console.WriteLine("Quantos numeros você vai digitar seu cocudo?");
        N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite um número");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Pares = 0;

        Console.WriteLine("Números pares: ");

        for (int i = 0; i < N; i++)
        {
            if(vetor[i] % 2 == 0)
            {
                Console.WriteLine(vetor[i] + "");
                Pares += 1;
            }
        }

        Console.WriteLine("Quantidade de pares = " + Pares);

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}