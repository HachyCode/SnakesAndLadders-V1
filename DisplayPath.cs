using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class DisplayPath
    {
        //Variables
        protected static string Star { get { return "*"; } }//Writes star * symbol
        protected static string SpaceLine { get { return "█"; } }//Writes coloured box symbol
        protected static string Space { get { return " "; } }//Creates space 
        protected static int vLineAmount { get { return 9; } }//Specifies amount of * in vertical / small line

        public static void HorizontalLine(int x, int y, int amount)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 1; i <= amount; i++)
            {
                Console.Write(Star);
            }
        }
        public static void VerticalLine(int x, int y, int amount)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 1; i <= amount; i++)
            {
                Console.Write(Star);
            }
        }
        public static void EmtyBox(int x, int y, int amount, int qty)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(x, y);
            for (int j = 1; j <= qty; j++)
            {
                for (int i = 1; i <= amount; i++)
                {
                    Console.Write(SpaceLine);
                }
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write(Space);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void VerticalBox(int x, int y, int qty)
        {
            for (int i = 1; i <= qty; i++)
            {
                EmtyBox(x + 2, ++y, 5, 1);
                VerticalLine(x, ++y, vLineAmount);
            }
        }
    }
}
