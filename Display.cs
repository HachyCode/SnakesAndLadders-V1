using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class Display : DisplayPath
    {

        //Path Variables
        private static int startHX { get { return 3; } }
        private static int startHY { get { return 1; } }
        private static int startHY2 { get { return startHY + 2; } }

        private static int startVX { get { return hLineAmount - vLineAmount + startHX; } }
        private static int startVY { get { return startHY + 4; } }

        private static int spaceHX { get { return startHX + 2; } }
        private static int spaceHY { get { return startHY + 1; } }

        private static int spaceVX { get { return startVX; } }
        private static int spaceVY { get { return startVY - 2; } }

        private static int secLineH { get { return 8; } }
        private static int thirdLineH { get { return secLineH + 10; } }

        private static int secLineV { get { return 3; } }
        private static int thirdLineV { get { return 4; } }

        private static int hLineAmount { get { return 89; } }
        private static int spaceAmount { get { return 5; } }

        private static int qtyAmountH { get { return 11; } }
        private static int qtyAmountV { get { return 1; } }

        //Dice Variable
        private static int diceX { get { return 50; } }
        private static int diceY { get { return 12; } }

        public void StartDisplay()
        {
            PathDisplay();
            DiceBoxDisplay();
        }

        public void PathDisplay()
        {
            Console.Clear();//Clear the screen.
            Console.CursorVisible = false;//Hiddes the curser.

            HorizontalLine(startHX, startHY, hLineAmount);
            EmtyBox(spaceHX, spaceHY, spaceAmount, qtyAmountH);
            HorizontalLine(startHX, startHY2, hLineAmount);

            VerticalBox(spaceVX, spaceVY, secLineV);

            HorizontalLine(startHX , startHY + secLineH, hLineAmount);
            EmtyBox(spaceHX, spaceHY + secLineH, spaceAmount, qtyAmountH);
            HorizontalLine(startHX, startHY2 + secLineH, hLineAmount);

            VerticalBox(startHX, spaceVY + secLineH, thirdLineV);

            HorizontalLine(startHX, startHY + thirdLineH, hLineAmount);
            EmtyBox(spaceHX, spaceHY + thirdLineH, spaceAmount, qtyAmountH);
            HorizontalLine(startHX, startHY2 + thirdLineH, hLineAmount);
        }

        public static void Ladder(int lenght, int x, int y)
        {
            //Will be moved to Decoration Class
        }
        public static void Snake(int lenght, int x, int y)
        {
            //Will be moved to Decoration Class
        }
        public static void DiceBoxDisplay()
        {
            DisplayDice.DiceBox(diceX, diceY);
            DisplayDice.DisplayOne();
        }
        public static void Logo(int x,int y)
        {
            //Will be moved to Decoration Class
        }
    }
}
