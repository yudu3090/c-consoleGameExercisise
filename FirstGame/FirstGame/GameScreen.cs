using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class GameScreen: IRenderable
    {
        private int width;
        private int height;
        private Hero hero;
        private List<Enemy> Enemies = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public Hero GetHero()
        {
            return hero;
        }

        public void AddEnemy(Enemy enemy)
        {
            Enemies.Add(enemy);
        }

        public void AddEnemy() 
        { 
            Random random = new Random(); 
            int x = random.Next(0, width); 
            AddEnemy(new Enemy(0, x, 1, "Name")); 
        } 

        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in Enemies)
            {
                enemy.MoveDown(10);
            }
        }

        public void MoveTheHeroesDown()
        {
            hero.MoveLeft();
            hero.PrintInfo();
       }

        public Enemy GetEnemyByID(int id)
        {
            foreach (Enemy enemy in Enemies)
            {
                if (enemy.GetID() == id)
                {
                    return enemy;
                }
            }

            return null;
        }

        public void Render()
        {
            hero.PrintInfo();
            foreach (Enemy enemy in Enemies)
            {
                enemy.PrintInfo();
            }
        }

    }
}