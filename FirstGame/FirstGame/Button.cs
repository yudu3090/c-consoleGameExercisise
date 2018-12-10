using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class Button : GuiObject, IRenderable
    {
        private Frame activeFrame;
        private Frame notActiveFrame;
        private TextLine textLine;
        protected bool isActive = false;

        public Button(int x, int y, int height, int width, string sTextLine) : base (x, y, height, width)
        {
            notActiveFrame = new Frame(x, y, width, height, '+');
            activeFrame = new Frame(x, y, width, height, '#');

            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, sTextLine);
        }
        public void Render()
        {
            if (isActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }

            textLine.Render();
        }

        public void Enable()
        {
            isActive = true;
        }

        public void Disable()
        {
            isActive = false;
        }
    }
}


