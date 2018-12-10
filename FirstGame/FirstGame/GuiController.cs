using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class GuiController
    {
        GameController gameController;
        GameWindow gameWindow;
        CreditWindow creditWindow;
        
        ConsoleKey choice; //paspaudimui fiksuoti

        public GuiController()
        {
            //perkeliau is Program
            gameWindow = new GameWindow();
            creditWindow = new CreditWindow();
            gameController = new GameController();
        }

        public void NavigationMeniu()
        {
            Console.Clear();
            gameWindow.Render();
            bool exit = false;
            int active;
            do
            {
                //aktyvus pirmas meniu mygtukas
                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.RightArrow:
                        gameWindow.MoveArrow(false, true);
                        break;
                    case ConsoleKey.LeftArrow:
                        gameWindow.MoveArrow(true, false);
                        break;
                    case ConsoleKey.Enter:
                        active = gameWindow.Get();
                        if (active == 1)
                        {
                            gameController.StartGame();
                        }
                        else if (active == 2)
                        {
                            CreditWindow();
                        }
                        else if (active == 3)
                        {
                            return;
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
           
                Console.Clear();
                gameWindow.Render();
            } while (!exit);
        }

        public void CreditWindow()
        {
            Console.Clear();
            creditWindow.Render();
            bool exit = false;
            while (!exit)
            {
                choice = Console.ReadKey(true).Key;
                if (choice == ConsoleKey.Enter || choice == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }
    }
}


