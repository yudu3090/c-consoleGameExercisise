using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GuiController guiController = new GuiController();
            guiController.NavigationMeniu();
            Console.CursorVisible = false;
            //Console.ReadKey();           
        }
        
    }
}
