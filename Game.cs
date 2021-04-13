using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    //enumeration
    enum Turn 
    {
        Player,
        Computer
    }

    //Facade pattern class, Strategy pattern client
    class Game 
    {
        //instantiating enumeration
        public static Turn turn = Turn.Player;

        // bool verable
        public static bool End = false;

        // Instantiating PathInfo class
        public static PathInfo path = new PathInfo();

        //Singleton Pattern
        static private Game instance = new Game();

        //Singleton Pattern
        private Game() 
        {
            do
            {
                // if its player turn
                if (turn == Turn.Player && !End) 
                {
                    Console.WriteLine("Player");
                    //Waites till user presses D key. and the runs the dice randomaiser.
                    KeyControl.Run();
                    Console.WriteLine("d " + Dice.diceNumber);
                    // add dinc number to player place.
                    Player.PlayerGo(Dice.diceNumber);
                    Console.WriteLine("p " + Player.PlayerPlace);
                    // cheaks if player is on one of the special tiles. if yes sets player place to go to tile
                    SpecialTileCheak();
                    //if plaeyr is on the path 40 or more it ends the game making it player a winner.
                    EndCheak(); 
                    Console.WriteLine(" ");
                }

                //if its computer turn
                if (turn == Turn.Computer && !End) 
                {
                    Console.WriteLine("Computer");
                    //runs the dice random number method as it dosent require any.
                    DiceThrow(); 
                    Console.WriteLine("d " + Dice.diceNumber);
                    Computer.ComputerGo(Dice.diceNumber);
                    Console.WriteLine("p " + Computer.ComputerPlace);
                    // cheaks if computer is on one of the special tiles. if yes sets computer place to go to tile.
                    SpecialTileCheak();
                    //if computer is on the path 40 or more it ends the game making it computer a winner.
                    EndCheak(); 
                    Console.WriteLine(" ");
                }
            // runs the algorithms while the game is not end
            } while (!End); 
        }

        //Singleton Pattern
        public static Game GetInstance() 
        {
            if(instance == null)
            {
                instance = new Game();
            }

            return instance;
        }

        public static void DiceThrow()
        {
            //Sets dic to rundom number
            Dice.RandomNumber();
            // runs change turn method
            ChangeTurn();
        }

        //changies the turn to next.
        private static void ChangeTurn() 
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
            //sets SetSpecialTile to run snakeA
            path.SetSpecialTile(new SnakesA()); 
            path.SpecialTile();

            //sets SetSpecialTile to runs LadderA
            path.SetSpecialTile(new LadderA()); 
            path.SpecialTile();
        }

        //cheks the place and if it 40 or bigger make game end displaying the winner.
        private static void EndCheak() 
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
