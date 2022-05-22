using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Player player = new Player(100,50,15);
            player.ShowInfo();
        }
    }

    class Player
    {
        public int Health;
        public int Mana;
        public int Damage;

        public Player(int health, int mana, int damage)
        {
            Health = health;
            Mana = mana;
            Damage = damage;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Здоровье: {Health}");
            Console.WriteLine($"Мана: {Mana}");
            Console.WriteLine($"Урон: {Damage}");
        }
    }
}