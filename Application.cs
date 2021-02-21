using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class Application //Facade pattern client
    {
        public void Run()
        {
            Game.GetInstance(); //Singleton Pattern, Instantiates Game class

            Console.ReadKey(true);
        }
    }
}
