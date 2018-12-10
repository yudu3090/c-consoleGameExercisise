using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class Enemy : Unit
    {
        private int id;

        public Enemy(int id, int x, int y, string name) : base(x, y, name)
        {
            this.id = id;

        }

        public int MoveDown(int move)
        {
            y -= move;
            return y;
        }

        public int GetID()
        {
            return id;
        }

    }
}