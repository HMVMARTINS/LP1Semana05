using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1 ||int.TryParse(args[0],out int numberOfEnemies) || numberOfEnemies <=0)
            {
                Console.WriteLine("Indica um número válido de inimigos.");
                return;
            }

            Enemy[] enemies = new Enemy[numberOfEnemies];

            for (int i = 0; i < numberOfEnemies; i++)
            {
                Console.WriteLine($"Nome do inimigo {i + 1}: ");
                string enemyName = Console.ReadLine();

                enemies[i] = new Enemy(enemyName, 100, 100);
            }

            Console.WriteLine("Nome Health Shield");
            foreach (var enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}"); 
            }
        }
    }
}
