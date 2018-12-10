using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    sealed class TextBlock : GuiObject, IRenderable
    {
        private List<TextLine> Line = new List<TextLine>();

        public void Render()
        {

            for (int i = 0; i < Line.Count; i++)
            {
                Line[i].Render();
            }

        }
        public TextBlock (int x, int y, int width, List<string> textLine) : base (x, y, 0, width)
        {
            for(int i = 0; i < textLine.Count; i++)
        {
                Line.Add(new TextLine(x, y + i, width, textLine[i]));
            }
        }
    }
}
