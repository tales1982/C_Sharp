// Program.cs
using System;
using System.Threading;

namespace StopwatchApp
{
    internal static class Program
    {
        static void Main(string[] args)
        {
        
            var menu = new Menu();
            var time = new Timing();

            char unidade = '\0';

            do
            {
                menu.Show();
                Console.WriteLine("Digite o valor (ex.: 10s, 5m) ou 0 para sair.");

                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    unidade = '0';
                    break;
                }

                string aux = input.Trim().ToUpperInvariant();

                if (aux == "0")
                {
                    unidade = '0';
                    Console.WriteLine("Exit...");
                    break;
                }

                if (aux.Length < 2)
                {
                    Console.WriteLine("Entrada muito curta. Use algo como 10s ou 5m.");
                    Thread.Sleep(1200);
                    continue;
                }

                unidade = aux[^1];
                string parteNumerica = aux[..^1];

                if (!int.TryParse(parteNumerica, out int valor) || valor <= 0)
                {
                    Console.WriteLine("Valor numérico inválido. Digite apenas dígitos positivos (ex.: 15s).");
                    Thread.Sleep(1200);
                    continue;
                }

                switch (unidade)
                {
                    case 'S':
                        Console.WriteLine("Cronômetro em segundos...");
                        menu.PreStart();
                        time.ConvertSeconds(valor);
                        break;

                    case 'M':
                        Console.WriteLine("Cronômetro em minutos...");
                        menu.PreStart();
                        time.ConvertMinutes(valor);
                        break;

                    default:
                        Console.WriteLine("Unidade inválida. Use S (segundos) ou M (minutos).");
                        Thread.Sleep(1200);
                        break;
                }

            } while (unidade != '0');
        }
    }
}
