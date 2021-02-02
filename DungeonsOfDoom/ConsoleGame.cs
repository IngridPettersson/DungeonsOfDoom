using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class ConsoleGame
    {
        Player player;
        Room[,] world;
        Random random = new Random();

        public void Play()
        {
            CreatePlayer();
            CreateWorld();

            do
            {
                Console.Clear();
                DisplayWorld();
                DisplayStats();
                AskForMovement();
                CheckForEvent();
            } while (player.Health > 0);

            GameOver();
        }

        private void CheckForEvent()
        {
            if (world[player.X, player.Y].Item != null)
            {
                player.BackPack.Add(world[player.X, player.Y].Item);
                world[player.X, player.Y].Item = null;
            }
            if (world[player.X, player.Y].Monster != null)
                StartFight(player, world[player.X, player.Y].Monster);
        }

        private void StartFight(Character attacker, Character defender)
        {
            Console.WriteLine($"Name: {defender.Name} Health: {defender.Health} Strength: {defender.Strength}");
        }

        private void CreatePlayer()
        {
            player = new Player();
        }


        private void CreateWorld()
        {
            world = new Room[20, 5];
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    int percentage = random.Next(0, 100);
                    if (percentage < 5)
                        world[x, y].Monster = new Zombie();
                    else if (percentage < 10)
                        world[x, y].Monster = new Warlock();
                    else if (percentage < 15)
                        world[x, y].Item = new ThunderHoney();
                    else if (percentage < 20)
                        world[x, y].Item = new InvisibilityCloak();

                }
            }
        }

        // Ändra is keyword till .Name med hänvisning till ny property för att jämföra typ av Item och Monster i if else statements. Kan ju skicka in samma string
        // om vi inte vill veta i förväg vilket typ av Item/Monster.
        private void DisplayWorld()
        {
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    Room room = world[x, y];
                    if (player.X == x && player.Y == y)
                        Console.Write("P");
                    else if (room.Monster != null)
                        Console.Write(room.Monster.Name[0]);
                    else if (room.Item != null)
                        Console.Write(room.Item.Name[0]);
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        private void DisplayStats()
        {
            //int honeyCount = 0;
            //int cloakCount = 0;
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine("Collected items:");
            foreach (var item in player.BackPack)
                Console.WriteLine(item.Name);
            //{
            //    if (item is ThunderHoney)
            //    {
            //        honeyCount++;
            //        Console.WriteLine($"{item.Name}: {honeyCount}");

            //    }

            //    else if (item is InvisibilityCloak)
            //    {
            //        cloakCount++;
            //        Console.WriteLine($"{item.Name}: {cloakCount}");
            //    }


            //}
        }

        private void AskForMovement()
        {
            int newX = player.X;
            int newY = player.Y;
            bool isValidKey = true;

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                default: isValidKey = false; break;
            }

            if (isValidKey &&
                newX >= 0 && newX < world.GetLength(0) &&
                newY >= 0 && newY < world.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;
            }
        }

        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over...");
            Console.ReadKey();
            Play();
        }
    }
}
