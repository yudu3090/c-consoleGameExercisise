using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Game
{
    class Unit
    {

        protected int x;
        protected int y;
        private string name;

        public Unit(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Unit {name} is at {x}x{y}");
        }
    }
}
