using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class Hero : Unit
    {
        public Hero(int x, int y, string name) : base(x, y, name)
        {
            
        }

        public int MoveRight()
        {
            x += 1;
            return x;
        }

        public int MoveLeft()
        {
            x -= 1;
            return x;
        }


    }

}