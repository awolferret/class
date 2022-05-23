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
        private int _health;
        private int _mana;
        private int _damage;

        public Player(int health, int mana, int damage)
        {
            _health = health;
            _mana = mana;
            _damage = damage;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Здоровье: {_health}");
            Console.WriteLine($"Мана: {_mana}");
            Console.WriteLine($"Урон: {_damage}");
        }
    }
}