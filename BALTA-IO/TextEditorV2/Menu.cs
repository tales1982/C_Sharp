using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextEditorV2
{
    public class Menu
    {
        public void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" =================== MENU ====================");
            Console.WriteLine("|           1 - Criar um arquivo             |");
            Console.WriteLine("|           2 - Ler um arquivo               |");
            Console.WriteLine("|           3 - Sair                         |");
            Console.WriteLine(" =============================================");
        }

        public void CriarArquivo(string txt){
            string? frase;
            
        }
    }
}