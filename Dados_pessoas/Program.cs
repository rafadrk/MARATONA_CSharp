using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Atividade - Dados Pessoas ");
        Console.WriteLine();


        int n, i, contm, conth;
        float menoraltura, maioraltura, soma, media;
        string[] generos = new string[99];
        float[] alturas = new float[99];

        Console.WriteLine("Quantas pessoas serão digitadas? ");
        n = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            Console.WriteLine("ALTURA da " + (i + 1) + "a PESSOA: ");
            alturas[i] = float.Parse(Console.ReadLine());
            Console.WriteLine("GENERO da " + (i + 1) + "a PESSOA: ");
            generos[i] = Console.ReadLine();
        }

        menoraltura = alturas[0];
        maioraltura = alturas[0];

        for (i = 0; i < n; i++)
        {
            if (alturas[i] > maioraltura)
            {
                maioraltura = alturas[i];
            }
            if (alturas[i] < menoraltura)
            {
                menoraltura = alturas[i];
            }
        }

        Console.WriteLine("MENOR ALTURA = " + menoraltura);
        Console.WriteLine("MAIOR ALTURA = " + maioraltura);

        soma = 0;
        contm = 0;

        for (i = 0; i < n; i++)
        {
            if (generos[i] == "F")
            {
                soma = soma + alturas[i];
                contm = contm + 1;
            }
        }

        if (contm == 0)
        {
            Console.WriteLine("Impossivel calcular a altura media das mulheres!!!");
        }
        else
        {
            media = soma / contm;
            Console.WriteLine("Media das alturas das mulheres = " + media);
        }

        conth = n - contm;
        Console.WriteLine("NUMERO DE HOMENS: " + conth);

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}