using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  -  acima diagonal");
        Console.WriteLine();

        int N, soma;

        Console.WriteLine("Qual a ordem da matriz? ");
        N = int.Parse(Console.ReadLine());

        string[] Vetormat = new string[09];
        int[,] matriz = new int[N, N];

        for (int i = 0; i < N; i++)
        {

            for (int j = 0; j < N; j++)
            {
                Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }


        }

        soma = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i < j)
                {

                    soma = soma + matriz[i, j];

                }

            }




            Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + soma);






            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}