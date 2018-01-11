using System;
using System.Collections.Generic;

class MainApp {
    static void Main() {
        int enemyCount = 0;
        Random rnd = new Random();

        Hero myHero = new Hero(5, 5, "HERO");
        List<Enemy> enemies = new List<Enemy>();
        for (int i = 0; i < 10; i++) {
            enemies.Add(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
            enemyCount++;
        }

        myHero.PrintInfo();
        foreach (Enemy enemy in enemies) {
            enemy.PrintInfo();
        }

        myHero.MoveLeft();
        foreach (Enemy enemy in enemies) {
            enemy.MoveDown();
        }

        myHero.PrintInfo();
        foreach (Enemy enemy in enemies) {
            enemy.PrintInfo();
        }

        Console.ReadKey();
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

}