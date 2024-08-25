using System;
using System.Collections.Generic;


class Program

{

    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao Gerador de apostas.");

        // Pergunta ao usuário a quantidade de apostas.
        Console.Write("Quantas apostas você deseja fazer?");
        int quantidadeApostas = int.Parse(Console.ReadLine());

        // Pergunta ao usúario a quantidade de números por aposta.
        Console.Write("Quantos números por aposta?");
        int numerosPorApostas = int.Parse(Console.ReadLine());

        // Pergunta ao usuário o intervalo máximo de números disponíveis.
        Console.Write("Informe o número máximo disponível no sorteio.");
        int maximoNumero = int.Parse(Console.ReadLine());


        //Gera as apostas.
        for (int i = 0; i < quantidadeApostas; i++)
        {
            List<int> aposta = GerarApostas(numerosPorApostas, maximoNumero);
            Console.WriteLine($"Aposta {i + 1}: {string.Join(",", aposta)}");
        }
    }

    static List<int> GerarApostas(int quantidadeDeNumeros, int maximoNumero)
    {
        Random random = new Random();
        List<int> numerosSorteados = new List<int>();

        while (numerosSorteados.Count < quantidadeDeNumeros)
        {
            int numero = random.Next(1, maximoNumero + 1);
            if (!numerosSorteados.Contains(numero))
            {
                numerosSorteados.Add(numero);
            }
        }
        return numerosSorteados;
    }

}