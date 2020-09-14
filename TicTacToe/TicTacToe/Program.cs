using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadKey();

            switch (x.KeyChar)
            {
                case '1':
                Console.WriteLine("GOOD");
                    break;
                default:
                    Console.WriteLine("Zle");
                    break;
            }

            Console.WriteLine("Witaj w grze w kolko i krzyzyk");
            Rules rules = new Rules();
            rules.FillArray();
            rules.DisplayTable();
            rules.Start();
            rules.TurnO();
            rules.DisplayTable();
            Bot.BotTurnX(rules);
            rules.DisplayTable();
        }
    }
}
