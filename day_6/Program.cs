using System;

namespace day_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ievadiet skaitli:");

            string ievads = Console.ReadLine();

            Console.WriteLine(Pievienoskaitli(ievads));

            string izvade = Pievienoskaitli(ievads);

            Console.WriteLine(izvade);

            Console.ReadLine();
        }

        static string Pievienoskaitli(string skaitlis)
        {
            string rezultats = "mans skaitlis ir" + skaitlis;
            return rezultats;
        }
    }
}
