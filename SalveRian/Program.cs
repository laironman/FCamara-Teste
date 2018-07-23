using System;

namespace SalveRian
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
                var army = new Army();
                Console.Write("Soldados {0} Posição {1}", args[0], army.SaveSoldier(int.Parse(args[0])));
            }
        }

        private static bool Validate(string[] args)
        {
            if (args.Length != 1) return false;

            int result;
            if (!int.TryParse(args[0], out result)) return false;

            return result > 1;

        }

        private static bool HelpRequired(string param)
        {
            const string helpstr = "-h,--help,/?,?,-?";
            return helpstr.Contains(param);
        }

        private static void DisplayHelp()
        {
            Console.WriteLine("Salve Rian.");
            Console.WriteLine("por favor use a entrada no formato <quantidade>");
            Console.WriteLine("onde quantidade seja a quantidade de soldado no jogo e um inteiro maior que 1");
            Console.WriteLine("Ex: 5");
        }
    }
}
