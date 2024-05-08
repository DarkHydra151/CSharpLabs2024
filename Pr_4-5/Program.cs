using System;

namespace pr_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage player1 = new FireMage("Вогненний Маг", 10);
            Mage player2 = new WaterMage("Водяний Маг", 8);

            player1.HealthChanged += Player_HealthChanged;
            player2.HealthChanged += Player_HealthChanged;

            while (player1.IsAlive() && player2.IsAlive())
            {
                player1.Attack(player2);
                if (!player2.IsAlive()) break;

                player2.Attack(player1);
                if (!player1.IsAlive()) break;
            }

            if (player1.IsAlive())
                Console.WriteLine($"{player1.Name} переміг!");
            else if (player2.IsAlive())
                Console.WriteLine($"{player2.Name} переміг!");
            else
                Console.WriteLine("Нічия!");
        }

        private static void Player_HealthChanged(object sender, int newHealth)
        {
            Mage mage = sender as Mage;
            Console.WriteLine($"{mage.Name} має {newHealth}% здоров'я.");
        }
    }
}
