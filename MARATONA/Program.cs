using System;

class Altura
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto  -  Alturas");
        Console.WriteLine();

        int N, cont;
        double soma, media, porcentagem;

        Console.WriteLine("Quantas pessoas serão digitadas?");
        N = int.Parse(Console.ReadLine());

        string[] nomes = new string[N];
        int[] idades =  new int[N];
        float[] alturas = new float[N];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Dados da " + (i + 1) + "ª pessoa");
            Console.WriteLine("Nome: ");
            nomes[i] = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idades[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Altura: ");
            alturas[i] = float.Parse(Console.ReadLine());
        }

        soma = 0 ;

        for (int i = 0; i < N; i++)
        {
            soma += alturas[i];
        }

        media = 0 ;
        media = soma / N;

        Console.WriteLine();
        Console.WriteLine("Altura média: " + media.ToString("F"));

        cont = 0;

        for(int i = 0; i < N; i++)
        {
            if (idades[i] < 16)
            {
                cont += 1;
            }
        }

        porcentagem = (cont * 100) / N;
        Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem + "%");
        
        for (int i = 0; i < N; i++)
        {
            if(idades[i] <= 16)
            {
                Console.WriteLine(nomes[i]);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}