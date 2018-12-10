using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class Game
    {
        void StartGame()
        {
            int enemyCount = 10;
            bool needToRender = true;
            GameScreen myGame = new GameScreen(80, 30);
            Hero Hero1 = new Hero(12, 12, "Zorr");
            Hero1.PrintInfo();
            Hero1.MoveRight();
            Hero1.PrintInfo();

            Random r = new Random();

            List<Enemy> EnemyList = new List<Enemy>();

            for (int i = 0; i < enemyCount; i++)
            {
                Enemy enemy = new Enemy(i, r.Next(1, 100), r.Next(1, 100), "Enemy " + Convert.ToString(i));
                EnemyList.Add(enemy);
            }

            foreach (Enemy enemy in EnemyList)
            {
                enemy.PrintInfo();
            }

            foreach (Enemy enemy in EnemyList)
            {
                enemy.MoveDown(r.Next(1, 100));
            }

            foreach (Enemy enemy in EnemyList)
            {
                myGame.AddEnemy(enemy);
            }

            myGame.SetHero(Hero1);

            Console.WriteLine("======================================");
            myGame.Render();
            Hero1.MoveLeft();

            foreach (Enemy enemy in EnemyList)
            {
                myGame.MoveAllEnemiesDown();
            }
            Console.WriteLine("======================================");
            myGame.Render();
            foreach (Enemy enemy in EnemyList)
            {
                if (enemy.GetID() == 1)
                {
                    enemy.MoveDown(12);
                }

            }
            Console.WriteLine("======================================");
            myGame.Render();
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
                            foreach (Enemy enemy in EnemyList)
                            {
                                enemy.MoveDown(r.Next(1, 100));
                            }

                            break;
                        case ConsoleKey.LeftArrow:
                            Hero1.MoveLeft();
                            break;
                    }
                }

                myGame.Render();
                System.Threading.Thread.Sleep(250);

            } while (needToRender);
        }

    }
}



