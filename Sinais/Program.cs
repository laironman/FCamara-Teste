using System;
using System.Text.RegularExpressions;

namespace Sinais
{
    class Program
    {
        static void Main(string[] args)
        {
            if ((args.Length == 0 || HelpRequired(args[0])) || !Validate(args))
            {
                DisplayHelp();
            }
            else
            {
                var sinal = new Sinal();
                Console.Write("{0}={1}", args[0], sinal.Valida(args[0]));
            }
        }

        private static bool Validate(string[] args)
        {
            if (args.Length != 1) return false;

            Regex regex = new Regex(@"^[\[\]{}\(\)]+$");

            return regex.IsMatch(args[0]);
           
        }

        private static bool HelpRequired(string param)
        {
            const string helpstr = "-h,--help,/?,?,-?";
            return helpstr.Contains(param);
        }

        private static void DisplayHelp()
        {
            Console.WriteLine("Validação de Sequencia de Sinais.");
            Console.WriteLine("por favor use a entrada no formato <sequencia>");
            Console.WriteLine("onde sequencia possua apenas {} [] ou ()");
            Console.WriteLine("Ex: {[()]}");
        }
    }
}
