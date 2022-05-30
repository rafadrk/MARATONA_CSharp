using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Atividade Negativos");
        Console.WriteLine();

        int n, i;
        int[] vetor = new int[9];

        Console.WriteLine("Quantos numeros o COCUDO VAI DIGITAR? ");
        n = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Digite um NUMERO: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("NUMEROS NEGATIVOS: ");
        Console.WriteLine();

        for (i = 0; i < n; i++)
        {
            if (vetor[i] < 0)
            {
                Console.WriteLine(vetor[i]);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}