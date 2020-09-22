using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witaj w grze w kolko i krzyzyk");

            while (true)
            {

                Rules rules = new Rules();

                rules.FillArray();
                rules.Start();
                var pickSide = Console.ReadKey();

                switch (pickSide.KeyChar)
                {
                    case 'o':
                        rules.TurnO();
                        Bot.BotTurnX(rules);
                        rules.TurnO();
                        Bot.BotTurnX(rules);
                        rules.TurnO();
                        Bot.BotTurnX(rules);
                        //rules.Result
                        break;

                    case 'x':
                        Bot.BotTurnO(rules);
                        rules.TurnX();
                        Bot.BotTurnO(rules);
                        rules.TurnX();
                        Bot.BotTurnO(rules);
                        rules.TurnX();
                        break;
                    default:
                        Console.WriteLine("Nie wybrales strony!");
                        break;


                }
            }
        }
    }
}
