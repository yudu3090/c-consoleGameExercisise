using System;
using System.Collections.Generic;

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