using System;
using System.Collections.Generic;

class MainApp {
    static void Main() {
        // init game
        GameScreen myGame = new GameScreen(30, 20);

        // fill game with game data.
        myGame.SetHero(new Hero(5, 5, "HERO"));

        Random rnd = new Random();
        int enemyCount = 0;
        for (int i = 0; i < 10; i++) {
            myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
            enemyCount++;
        }

        // render loop
        bool needToRender = true;

        do {
            // isvalom ekrana
            Console.Clear();

            while (Console.KeyAvailable) {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                int hashCode = pressedChar.Key.GetHashCode();

                switch (hashCode) {
                    case 27: //ConsoleKey.Escape:
                        needToRender = false;
                        break;
                    case 39: // ConsoleKey.RightArrow:
                        myGame.GetHero().MoveRight();
                        break;
                    case 37: // ConsoleKey.LeftArrow:
                        myGame.GetHero().MoveLeft();
                        break;
                }
            }

            myGame.Render();

            System.Threading.Thread.Sleep(250);
        } while (needToRender);
    }
}


class GameScreen {
    private int width;
    private int height;

    private Hero hero;
    private List<Enemy> enemies = new List<Enemy>();

    public GameScreen(int width, int height) {
        this.width = width;
        this.height = height;
    }

    public void SetHero(Hero hero) {
        this.hero = hero;
    }

    public void AddEnemy(Enemy enemy) {
        enemies.Add(enemy);
    }

    public void Render() {
        hero.PrintInfo();
        foreach (Enemy enemy in enemies) {
            enemy.PrintInfo();
        }
    }

    public Hero GetHero() {
        return hero;
    }

    public void MoveAllEnemiesDown() {
        foreach (Enemy enemy in enemies) {
            enemy.MoveDown();
        }
    }

    public Enemy getEnemyById(int id) {
        foreach (Enemy enemy in enemies) {
            if (enemy.GetId() == id) {
                return enemy;
            }
        }

        return null;
    }
}


class Unit {

    protected int x;
    protected int y;
    private string name;

    public Unit(int x, int y, string name) {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    public void PrintInfo() {
        Console.WriteLine($" Unit {name} is at {x}x{y}");
    }
}

class Hero : Unit {

    public Hero(int x, int y, string name) : base(x, y, name) {
    }

    public void MoveRight() {
        x++;
    }

    public void MoveLeft() {
        x--;
    }
}


class Enemy : Unit {

    private int id;

    public Enemy(int id, int x, int y, string name) : base(x, y, name) {
        this.id = id;
    }

    public void MoveDown() {
        y++;
    }

    public int GetId() {
        return id;
    }
}