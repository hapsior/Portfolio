using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Bot : Rules
    {

        public static void BotTurnX(Rules rules)
        {
        Random random = new Random();

            int next=random.Next(0,9);
            if(rules.Array[next].Equals("O")||rules.Array[next].Equals("X"))

            while (!rules.Array[next].Equals("O") || rules.Array[next].Equals("X"));
            {
               next= random.Next(0, 9);
            }
            rules.Array[next] = "X";
        }
    }
}
