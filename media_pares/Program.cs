using System;

class media_pares
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  - média pares ");
        Console.WriteLine();

        int N, i, soma, contPares;
        double media;

        Console.WriteLine("Quantos elementos vai ter o vetor? ");
        N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];

        for (i = 0; i < N; i++)
        {
            Console.WriteLine("Digite um número : ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        soma = 0;
        contPares = 0;
        
        for (i = 0; i < N; i++)
        {
            if(vetor[i] % 2 == 0)
            {
                soma += vetor[i];
                contPares += 1;
            }
        }

        if (contPares == 0)
        {
            Console.WriteLine("NENHUM NUMERO PAR");
        } else
        {
            media = soma / contPares;
            Console.WriteLine("MEDIA DOS PARES = " + media);
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}