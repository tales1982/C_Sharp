namespace TextEditor;

public struct Menu
{
    public void Show()
    {
        Console.Clear();
        Console.WriteLine("Oque voce deseja fazer ?");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");

        short? option = null;
        string? input = Console.ReadLine();
        if (short.TryParse(input, out short parsed))
        {
            option = parsed;
        }

        switch (option)
        {
            case 0:
                System.Environment.Exit(0);
                break;
            case 1:
                Abrir();
                break;
            case 2:
                Editar();
                break;
            default:
                Show();
                break;

        }
    }

    public void Abrir()
    {
        string? path;

        Console.WriteLine("Qual e o caminho do arquivo ?");
        path = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(path))
        {
            Console.WriteLine("Digite um caminho!");
            return;
        }

        using (StreamReader leitor = new(path))
        {
            string conteudo = leitor.ReadToEnd();
            Console.WriteLine(conteudo);
        }
        Console.WriteLine("");
        Console.ReadLine();
        Show();
    }

    public void Editar()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo. Digite :q para sair e salvar");
        Console.WriteLine("-----------------------------------------------------");

        var sb = new System.Text.StringBuilder();

        while (true)
        {
            string? linha = Console.ReadLine();
            if (linha == null) break;                  // EOF (pouco comum no console)
            if (linha.Trim().Equals(":q", StringComparison.OrdinalIgnoreCase))
                break;                                  // comando para encerrar

            sb.AppendLine(linha);
        }

        Salve(sb.ToString());
    }


    public void Salve(string texto)
    {
        Console.Clear();
        Console.WriteLine("Qual caminho para salvar o arquivo?");
        string? path = Console.ReadLine();//home/tales/Documents/

        if (string.IsNullOrWhiteSpace(path))
        {
            Console.WriteLine("Caminho inválido. Operação cancelada.");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            return;
        }

        using (StreamWriter file = new(path))
        {
            file.Write(texto);
        }

        Console.WriteLine($"Arquivo {path} salvo com sucesso");
        Show();

    }
}
