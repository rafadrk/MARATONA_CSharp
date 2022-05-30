using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  -  Matriz geral");
        Console.WriteLine();

        int n, i, j, linha, coluna;

        double somapositivos;

        Console.WriteLine("Qual a ordem da matriz?");
        n = int.Parse(Console.ReadLine());

        double[,] matriz = new double[n, n];

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.WriteLine("Elemento [ " + i + " , " + j + " ]: ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }

        somapositivos = 0;

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (matriz[i, j] > 0)
                {
                    somapositivos = somapositivos + matriz[i, j];
                }
            }
        }

        Console.WriteLine(" Soma dos positivos: " + somapositivos.ToString("F"));

        Console.WriteLine("Escolha uma linha: ");
        linha = int.Parse(Console.ReadLine());

        Console.WriteLine("Linha escolhida: ");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine(matriz[linha, i].ToString("F") + "  ");
        }

        Console.WriteLine("Escolha uma coluna: ");
        coluna = int.Parse(Console.ReadLine());

        Console.WriteLine("Coluna escolhida: ");

        for (i = 0; i < n; i++)
        {
            Console.WriteLine(matriz[i, coluna].ToString("F") + " ");
        }

        Console.WriteLine("Diagonal principal: ");


        for (i = 0; i < n; i++)
        {
            Console.WriteLine(matriz[i, i].ToString("F") + " ");
        }
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (matriz[i, j] < 0)
                {
                    matriz[i, j] = Math.Pow(matriz[i, j], 2);
                }
            }
        }

        Console.WriteLine("Matriz alterada: ");

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.WriteLine(matriz[i, j].ToString("F") + " ");
            }
            Console.WriteLine();
        }





        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}