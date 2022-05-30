using System;

class Mais_Velho
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto  -  mais velho ");
        Console.WriteLine();

        int N, posMaior, maior;

        Console.WriteLine("Quantas pessoas você vai digitar?");
        N = int.Parse(Console.ReadLine());

        string[] nomes = new string[N];
        int[] idades = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Dados da " + (i + 1) + "ª pessoa");
            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine();
            Console.Write("Idade: ");
            idades[i] = int.Parse(Console.ReadLine());

        }

        maior = idades[0];
        posMaior = 0;

        for (int i = 1; i < N; i++)
        {
            if (idades[i] > maior)
            {
                posMaior = i;
            }
        }

        Console.WriteLine("Pessoa mais velha: " + nomes[posMaior]);

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}