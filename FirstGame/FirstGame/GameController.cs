using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class GameController
    {
        public void StartGame()
        {
            GameScreen myGame = new GameScreen(40, 50);
            myGame.SetHero(new Hero(40, 60, "Thorr"));
            Random rnd = new Random();
            bool needToRender = true;
            do
                {
                Console.Clear();
                
            while (Console.KeyAvailable)
            {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);

            switch (pressedChar.Key)                      
            {
                case ConsoleKey.Escape:
                    needToRender = false;
                    break;
                case ConsoleKey.RightArrow:
                    myGame.GetHero().MoveRight();
                    break;
                case ConsoleKey.LeftArrow:
                    myGame.GetHero().MoveLeft();
                    break;
                        }
                    }
                
                myGame.MoveAllEnemiesDown();
                myGame.MoveTheHeroesDown();
                myGame.Render();
                System.Threading.Thread.Sleep(250);
            } while (needToRender);
        }
    }
}
