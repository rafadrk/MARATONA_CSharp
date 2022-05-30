using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Atividade Maior Posição");
        Console.WriteLine();

        int n, i, posmaior;
        float maior;
        float[] vetor = new float[99];

        Console.WriteLine("Quantos Números você vai digitar? ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (i = 0; i < n; i++)
        {
            Console.WriteLine("DIGITE UM NUMERO COCUDO: ");
            vetor[i] = float.Parse(Console.ReadLine());
        }

        posmaior = 0;
        maior = vetor[0];

        for (i = 1; i < n; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
                posmaior = i;
            }
        }
        Console.WriteLine();

        Console.WriteLine("MAIOR VALOR = " + maior);
        Console.WriteLine("POSIÇÃO DO MAIOR VALOR: " + (posmaior + 1));

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}