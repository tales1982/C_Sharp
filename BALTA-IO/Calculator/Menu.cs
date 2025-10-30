using System;

namespace Calculator
{
    public struct Menu
    {
        // Códigos de cor ANSI (padrão Linux/macOS)
        private const string RESET  = "\u001b[0m";
        private const string BOLD   = "\u001b[1m";
        private const string BLUE   = "\u001b[34m";
        private const string CYAN   = "\u001b[36m";
        private const string YELLOW = "\u001b[33m";
        private const string GREEN  = "\u001b[32m";
        private const string RED    = "\u001b[31m";
        private const string MAGENTA = "\u001b[35m";

        public void Show()
        {
            Console.Clear();

            Console.WriteLine($"{BOLD}{CYAN}╔══════════════════════════════╗{RESET}");
            Console.WriteLine($"{BOLD}{CYAN}║          CALCULATOR          ║{RESET}");
            Console.WriteLine($"{BOLD}{CYAN}╚══════════════════════════════╝{RESET}\n");

            Console.WriteLine($"{YELLOW}================== MENU =================={RESET}");
            Console.WriteLine($"    {GREEN}1){RESET} {BOLD}+  (Addition){RESET}");
            Console.WriteLine($"    {GREEN}2){RESET} {BOLD}-  (Subtraction){RESET}");
            Console.WriteLine($"    {GREEN}3){RESET} {BOLD}/  (Division){RESET}");
            Console.WriteLine($"    {GREEN}4){RESET} {BOLD}*  (Multiplication){RESET}");
            Console.WriteLine($"    {GREEN}5){RESET} {BOLD}%  (Modulo / Remainder){RESET}");
            Console.Write($"    {RED}6){RESET} {BOLD}EXIT{RESET}");
            Console.WriteLine();
            Console.WriteLine($"{YELLOW}=========================================={RESET}");
            Console.Write($"{MAGENTA}Escolha uma operação:{RESET} ");
        }
    }
}
