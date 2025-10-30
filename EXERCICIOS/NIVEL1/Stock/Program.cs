//Nível 1: Entrada, Processamento e Saída
//Faça um programa para calcular o estoque médio de uma peça, sendo que: 
//ESTOQUE MEDIO = (QUANTIDADE + QUANTIDADE_MAXIMA) / 2

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int quantity = 0;
        int quantityMax = 0;
        float medio;

        Console.Write("Digite a quantidade atual: ");
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out quantity))
        {
            Environment.Exit(1);
        }

        Console.Write("Digite a quantidade máxima: ");
        input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out quantityMax))
        {
            Environment.Exit(1);
        }

        medio = (quantity + quantityMax) / 2.0f;

        Console.WriteLine("Estoque médio = " + medio.ToString("F2", CultureInfo.InvariantCulture));
    }
}