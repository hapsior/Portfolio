using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace TicTacToe
{
    public class Rules
    {
        public string[] Array { get; set; }

        public void Start()
        {
            Console.WriteLine("Wybierz kolko czy krzyzyk (kolko zaczyna)");
            DisplayTable();

            var pick = Console.ReadKey();
            Console.WriteLine();

        }
        public void DisplayTable()
        {
            Console.WriteLine(new string('-', 10));
            Console.WriteLine($" {Array[0]} {Array[1]} {Array[2]} ");
            Console.WriteLine($" {Array[3]} {Array[4]} {Array[5]} ");
            Console.WriteLine($" {Array[6]} {Array[7]} {Array[8]} ");

        }

        public void FillArray()
        {
            Array = new string[9];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Convert.ToString(i);
            }
        }
        public void TurnX()
        {
            int placeInArray;

            Console.WriteLine("Gdzie chcesz postawic X?");
            var number = Console.ReadLine();
            int.TryParse(number, out placeInArray);
            while (placeInArray < 0 || placeInArray > 9 && Array[placeInArray] == "X" || Array[placeInArray] == "O")
            {
                Console.WriteLine("Nie ma takiego miejsca na planszy! Gdzie chcesz postawic X?");
                number = Console.ReadLine();
                int.TryParse(number, out placeInArray);
            }
            Array[placeInArray] = "X";
            DisplayTable();
        }
        public void TurnO()
        {
            int placeInArray;

            Console.WriteLine("Gdzie chcesz postawic O?");
            var number = Console.ReadLine();
            int.TryParse(number, out placeInArray);
            while (placeInArray < 0 || placeInArray > 9 && Array[placeInArray] == "X" || Array[placeInArray] == "O")
            {
                Console.WriteLine("Nie ma takiego dostepnego miejsca na planszy! Gdzie chcesz postawic O?");
                number = Console.ReadLine();
                int.TryParse(number, out placeInArray);
            }

            Array[placeInArray] = "O";
            DisplayTable();
        }
    }
}
