using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class DisplayDice
    {
        //Veriables
        protected static string DiceName { get { return "DICE"; } }

        protected static string DiceBoxVertical { get { return "═"; } }
        protected static string DiceBoxHorizontal { get { return "║"; } }

        protected static string DiceBoxTopL { get { return "╔"; } }
        protected static string DiceBoxTopR { get { return "╗"; } }
        protected static string DiceBoxBottomL { get { return "╚"; } }
        protected static string DiceBoxBottomR { get { return "╝"; } }

        protected static int DiceAmountV { get { return 7; } }
        protected static int DiceAmountH { get { return 4; } }

        //Methods
        public static void DiceBox(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(DiceName);

            Console.SetCursorPosition(x - 1, y + 1);
            Console.Write(DiceBoxTopL);
            for (int i = 1; i <= DiceAmountV; i++)
            {
                Console.Write(DiceBoxVertical);
            }
            Console.Write(DiceBoxTopR);

            for (int i = 2; i <= DiceAmountH; i++)
            {
                Console.SetCursorPosition(x - 1, y + i);
                Console.Write(DiceBoxHorizontal);

                Console.SetCursorPosition(x + DiceAmountV, y + i);
                Console.Write(DiceBoxHorizontal);
            }

            Console.SetCursorPosition(x - 1, y + 5);
            Console.Write(DiceBoxBottomL);
            for (int i = 1; i <= DiceAmountV; i++)
            {
                Console.Write(DiceBoxVertical);
            }
            Console.Write(DiceBoxBottomR);

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DiceNumbers(int x, int y)
        {
            
        }
        public static void DisplayOne()
        {

        }
        public void DisplayTwo()
        {

        }
        public void DisplayThree()
        {

        }
        public void DisplayFour()
        {

        }
        public void DisplayFive()
        {

        }
        public void DisplaySix()
        {

        }

        public void ThrowDiceRequest()
        {

        }
    }
}
