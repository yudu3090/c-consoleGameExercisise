using System;
using System.Collections.Generic;

class MainApp {
    static void Main() {
        GameScreen myGame = new GameScreen(30, 20);

        myGame.SetHero(new Hero(5, 5, "HERO"));

        Random rnd = new Random();
        int enemyCount = 0;
        for (int i = 0; i < 10; i++) {
            myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
            enemyCount++;
        }

        myGame.Render();

        myGame.GetHero().MoveLeft();
        myGame.MoveAllEnemiesDown();

        Enemy secondEnemy = myGame.getEnemyById(1);
        if (secondEnemy != null) {
            secondEnemy.MoveDown();
        }

        myGame.Render();

        Console.ReadKey();
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

class Hero {

    private int x;
    private int y;
    private string name;

    public Hero(int x, int y, string name) {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    public void MoveRight() {
        x++;
    }

    public void MoveLeft() {
        x--;
    }

    public void PrintInfo() {
        Console.WriteLine($" Hero {name} is at {x}x{y}");
    }
}


class Enemy {
    private int id;
    private int x;
    private int y;
    private string name;


    public Enemy(int id, int x, int y, string name) {
        this.id = id;
        this.x = x;
        this.y = y;
        this.name = name;
    }

    public void MoveDown() {
        y++;
    }

    public void PrintInfo() {
        Console.WriteLine($" Enemy {name} is at {x}x{y}");
    }

    public int GetId() {
        return id;
    }
}