using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class Window : GuiObject, IRenderable
    {
        private Frame border;
        

        public Window(int x, int y, int width, int height, char render) : base (x, y, height, width)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            border = new Frame(x, y, height, width, render);

        }

        public virtual void Render()
        {
            border.Render();
        }
    }
}


