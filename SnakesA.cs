using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class SnakesA : ISpecialTile
    {
        public int StandingOnTile() { return 22; }
        public int GoToTile() { return 33; }
    }
}
