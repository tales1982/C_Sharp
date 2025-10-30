using System;
using System.Globalization;   // Para Parse/ TryParse com cultura (ex.: "19,99" em pt-BR)
using System.Threading;       // Para Thread.Sleep

namespace FuncoesUtils
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Contagem regressiva (Thread.Sleep) ---
            int time = 0;
            int currentTime = 3;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime--;
                Console.WriteLine($"O programa vai iniciar em... {currentTime}");
                Thread.Sleep(1000); // segura o terminal por 1 segundo
            }

            // --- Entrada de nome e limpeza com Trim/TrimStart/TrimEnd ---
            Console.Write("Digite seu nome em letras minusculas (com espaços extras): ");
            string raw = Console.ReadLine() ?? string.Empty;

            // Demonstração das variações de Trim
            string soTrim = raw.Trim();        // remove dos dois lados
            string soTrimStart = raw.TrimStart();   // remove só do início
            string soTrimEnd = raw.TrimEnd();     // remove só do final

            Console.WriteLine($"\n[Trim]       => '{soTrim}'");
            Console.WriteLine($"[TrimStart]  => '{soTrimStart}'");
            Console.WriteLine($"[TrimEnd]    => '{soTrimEnd}'");

            // Normaliza para maiúsculas após limpar
            string str = soTrim.ToUpper();
            Console.WriteLine($"\nNormalizado (Trim + ToUpper): '{str}'");

            // --- Length (tamanho da string) ---
            Console.WriteLine($"Tamanho (Length): {str.Length}");

            // --- Pegando o último caractere de 3 maneiras diferentes ---
            if (str.Length > 0)
            {
                // 1) Acesso direto por índice
                char ultimo1 = str[str.Length - 1];

                // 2) Substring + char.Parse
                char ultimo2 = char.Parse(str.Substring(str.Length - 1, 1));

                // 3) Substring + char.TryParse (forma segura)
                char ultimo3 = '?';
                if (char.TryParse(str.Substring(str.Length - 1, 1), out char tmp))
                    ultimo3 = tmp;

                Console.WriteLine($"\nÚltimo caractere (índice): {ultimo1}");
                Console.WriteLine($"Último caractere (Substring + Parse): {ultimo2}");
                Console.WriteLine($"Último caractere (Substring + TryParse): {ultimo3}");
            }
            else
            {
                Console.WriteLine("\nString vazia após Trim — não há último caractere.");
            }

            // --- Substring: fatias da string versao antiga---
            if (str.Length >= 3)
            {
                string tresPrimeiras = str.Substring(0, 3);    // 3 primeiros caracteres
                string doMeioAteFim = str.Substring(1);       // do índice 1 até o fim
                Console.WriteLine($"\nSubstring(0,3) versao ANTIGA : {tresPrimeiras}");
                Console.WriteLine($"Substring(1) versao ANTIGA :   {doMeioAteFim}");
            }

            // --- Substring: fatias da string versao NOVA C# +8 ---
            string texto = "TALES";
            string inicioPenultimo = texto[..^1];//TALE
            char ultimoTexto = texto[^1];//S
       

            Console.WriteLine($"Substring (Range Operator)(0,3) Versao NOVA {inicioPenultimo}");
            Console.WriteLine($"Substring (Range Operator)(1) Versao NOVA {ultimoTexto}");




            // --- TryParse seguro para idade (evita exceção) ---
            Console.Write("\nDigite sua idade (número inteiro): ");
            string entradaIdade = (Console.ReadLine() ?? string.Empty).Trim();

            if (!int.TryParse(entradaIdade, out int idade))
            {
                Console.WriteLine("Idade inválida! Encerrando com código 1...");
                Environment.Exit(1); // Sai do programa inteiro com erro
            }
            Console.WriteLine($"Idade válida ✅: {idade}");

            // --- Parse e TryParse com números decimais ---
            Console.Write("Digite um preço em pt-BR (ex.: 19,99): ");
            string entradaPreco = (Console.ReadLine() ?? string.Empty).Trim();

            // TryParse seguro com cultura pt-BR
            if (decimal.TryParse(entradaPreco, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal preco))
            {
                Console.WriteLine($"Preço válido ✅: {preco:C} (pt-BR)");
            }
            else
            {
                Console.WriteLine("Preço inválido. Vou tentar com cultura invariante (ponto como separador)...");
                try
                {
                    // Parse "forçado" com cultura invariante (padrão: 19.99)
                    decimal precoInvariant = decimal.Parse(entradaPreco, CultureInfo.InvariantCulture);
                    Console.WriteLine($"Preço (InvariantCulture) ✅: {precoInvariant}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ainda inválido. Seguindo sem preço...");
                }
            }

            // --- Exemplo final: usar tudo junto pra validar um código "LUX-2025-ZAORI" ---
            Console.Write("\nDigite um código no formato LUX-YYYY-NOME (ex.: LUX-2025-ZAORI): ");
            string codigo = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();

            // Verifica tamanho mínimo e estrutura básica
            if (codigo.Length >= 10 && codigo.Contains("-"))
            {
                // Pega partes com Substring usando posições conhecidas
                // LUX-2025-ZAORI
                // 012345678901234 (índices)
                // pais: 0..3, ano: 4..8, nome: a partir de 9 (pulando o hífen)
                try
                {
                    string pais = codigo.Substring(0, 3);
                    string anoStr = codigo.Substring(4, 4);
                    string nome = codigo.Substring(9).Trim('-');

                    if (int.TryParse(anoStr, out int ano))
                    {
                        Console.WriteLine($"\nCódigo OK ✅");
                        Console.WriteLine($"País: {pais}");
                        Console.WriteLine($"Ano:  {ano}");
                        Console.WriteLine($"Nome: {nome}");
                    }
                    else
                    {
                        Console.WriteLine("\nAno inválido dentro do código! Encerrando com código 2...");
                        Environment.Exit(2);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("\nFormato do código inválido (tamanho/posições). Encerrando com código 3...");
                    Environment.Exit(3);
                }
            }
            else
            {
                Console.WriteLine("\nFormato básico inválido (esperado LUX-YYYY-NOME). Encerrando com código 4...");
                Environment.Exit(4);
            }

            Console.WriteLine("\nTudo concluído com sucesso ✅");
            Environment.Exit(0); // encerra o programa com sucesso
        }
    }
}
