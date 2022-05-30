using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  - Soma Vetores ");
        Console.WriteLine();

        int N, i;

        Console.WriteLine("Quantos valores vão ter cada vetor seu cocudo?");
        N = int.Parse(Console.ReadLine());

        int[] A = new int[N];
        int[] B = new int[N];
        int[] C = new int[N];

        Console.WriteLine("Digite os valores do vetor A: ");
        for (i = 0; i < N; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os valores do vetor B: ");
        for (i = 0; i < N; i++)
        {
            B[i] = int.Parse(Console.ReadLine());
        }

        for(i = 0; i < N; i++)
        {
            C[i] = A[i] + B[i];
        }

        Console.WriteLine("Vetor Resultante: ");
        for(i = 0; i < N; i++)
        {
            Console.WriteLine(C[i]);
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}