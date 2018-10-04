using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Game
{
    class Hero : Unit
    {
        public Hero(int x, int y, string name) : base(x, y, name)
        {
        }

        public void MoveRight()
        {
            x++;
        }

        public void MoveLeft()
        {
            x--;
        }
    }
}
