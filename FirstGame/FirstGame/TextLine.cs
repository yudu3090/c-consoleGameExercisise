using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class TextLine : GuiObject, IRenderable
    {
        readonly private string _data; 
        public TextLine(int x, int y, int width, string textLine) : base (x, y, 0, width)
        {
            _data = textLine;
        }

        public void Render()
        {
            Console.SetCursorPosition(_x, _y);
            if (_width > _data.Length)
            {
                int offset = (_width - _data.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }

            Console.Write(_data);
        }
    }
}

