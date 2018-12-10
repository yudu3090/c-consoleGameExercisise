using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    abstract class GuiObject
    {
        
        protected int _x;
        protected int _y;
        protected int _height;
        protected int _width;

        public GuiObject(int x, int y, int height, int width)
        {
            _x = x;
            _y = y;
            _height = height;
            _width = width;

        }
    }
}
