using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    enum Turn //enumeration
    {
        Player,
        Computer
    }
    class Game //Facade pattern class, Strategy pattern client
    {
        public static Turn turn = Turn.Player; //instantiating enumeration

        public static bool End = false; // bool verable

        public static PathInfo path = new PathInfo(); // Instantiating PathInfo class

        static private Game instance = new Game(); //Singleton Pattern

        private Game() //Singleton Pattern
        {
            do
            {
                if (turn == Turn.Player && !End) // if its player turn
                {
                    Console.WriteLine("Player"); 
                    KeyControl.Run();//Waites till user presses D key. and the runs the dice randomaiser.
                    Console.WriteLine("d " + Dice.diceNumber);
                    Player.PlayerGo(Dice.diceNumber);// add dinc number to player place.
                    Console.WriteLine("p " + Player.PlayerPlace);
                    SpecialTileCheak();// cheaks if player is on one of the special tiles. if yes sets player place to go to tile
                    EndCheak(); //if plaeyr is on the path 40 or more it ends the game making it player a winner.
                    Console.WriteLine(" ");
                }

                if (turn == Turn.Computer && !End) //if its computer turn
                {
                    Console.WriteLine("Computer");
                    DiceThrow(); //runs the dice random number method as it dosent require any.
                    Console.WriteLine("d " + Dice.diceNumber);
                    Computer.ComputerGo(Dice.diceNumber);
                    Console.WriteLine("p " + Computer.ComputerPlace);
                    SpecialTileCheak(); // cheaks if computer is on one of the special tiles. if yes sets computer place to go to tile.
                    EndCheak(); //if computer is on the path 40 or more it ends the game making it computer a winner.
                    Console.WriteLine(" ");
                }
            } while (!End); // runs the algorithms while the game is not end
        }

        public static Game GetInstance() //Singleton Pattern
        {
            if(instance == null)
            {
                instance = new Game();
            }

            return instance;
        }

        public static void DiceThrow()
        {
            Dice.RandomNumber(); //Sets dic to rundom number
            ChangeTurn();// runs change turn method
        }

        private static void ChangeTurn() //changies the turn to next.
        {
            if(turn == Turn.Player)
            {
                turn = Turn.Computer;
            }
            else if (turn == Turn.Computer)
            {
                turn = Turn.Player;
            }
        }

        private static void SpecialTileCheak()
        {
            path.SetSpecialTile(new SnakesA()); //sets SetSpecialTile to run snakeA
            path.SpecialTile();
            path.SetSpecialTile(new LadderA()); //sets SetSpecialTile to runs LadderA
            path.SpecialTile();
        }

        private static void EndCheak() //cheks the place and if it 40 or bigger make game end displaying the winner.
        {
            if (Player.PlayerPlace >= PathInfo.LastTile())
            {
                Console.WriteLine("Winner is Player");
                End = true;
            }
            else if (Computer.ComputerPlace >= PathInfo.LastTile())
            {
                Console.WriteLine("Winner is Computer");
                End = true;
            }
        }
    }
}
