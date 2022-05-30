using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  - negativos matriz");
        Console.WriteLine();

        int m, n, i, j;

        Console.WriteLine("Qual a quantidade de linhas da matriz? ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual a quantidade de colunas da matriz? ");
        n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[m, n];

        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.WriteLine("Elemento [ " + i + "," + j + "]:");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Valores negativos: ");

        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (matriz[i, j] < 0)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
        }


        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}