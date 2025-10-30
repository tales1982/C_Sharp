// Program.cs
using Calculator;

Console.Clear();

string? aux = "0";
var menu = new Menu();
var operacao = new MathOperation();

float a = 0;
float b = 0;
float result = 0;

do
{
    menu.Show();
    Console.Write("Escolha sua operação... ");
    aux = Console.ReadLine()?.Trim(); // <- .Trim() remove espaços

    switch (aux)
    {
        case "1":
            Console.Write("Digite o primeiro valor: ");
            a = float.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o segundo valor: ");
            b = float.Parse(Console.ReadLine() ?? "0");

            result = operacao.Add(a, b);
            Console.WriteLine($"Resultado: {result}");
            break;

        case "2":
            Console.Write("Digite o primeiro valor: ");
            a = float.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o segundo valor: ");
            b = float.Parse(Console.ReadLine() ?? "0");

            result = operacao.Subtract(a, b);
            Console.WriteLine($"Resultado: {result}");
            break;

        case "3":
            Console.Write("Digite o primeiro valor: ");
            a = float.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o segundo valor: ");
            b = float.Parse(Console.ReadLine() ?? "1"); // evita divisão por zero

            if (b == 0)
            {
                Console.WriteLine("Erro: divisão por zero!");
            }
            else
            {
                result = operacao.Divide(a, b);
                Console.WriteLine($"Resultado: {result}");
            }
            break;

        case "4":
            Console.Write("Digite o primeiro valor: ");
            a = float.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o segundo valor: ");
            b = float.Parse(Console.ReadLine() ?? "0");

            result = operacao.Multiply(a, b); // ✅ corrigido o nome
            Console.WriteLine($"Resultado: {result}");
            break;

        case "5":
            Console.Write("Digite o primeiro valor: ");
            a = float.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o segundo valor: ");
            b = float.Parse(Console.ReadLine() ?? "1");

            result = operacao.Modulo(a, b);
            Console.WriteLine($"Resto da divisão: {result}");
            break;

        case "6":
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Digite um valor válido..");
            break;
    }

    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();

} while (aux != "6");
