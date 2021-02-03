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
                player.BackPack.Add(world[player.X, player.Y].Item, 1);
                world[player.X, player.Y].Item = null;
            }
            if (world[player.X, player.Y].Monster != null)
                StartFight(player, world[player.X, player.Y].Monster);
        }

        private void StartFight(Character attacker, Character defender)
        {
            attacker.Attack(defender);
            if (defender.Health < 1)
            {
                world[player.X, player.Y].Monster = null;
            }

            defender.Attack(attacker);
            if (attacker.Health < 1)
            {
                world[player.X, player.Y] = null;
            }

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
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("P");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
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

        private void ChooseItem()
        {
            Console.WriteLine("Menu...");
            ConsoleKeyInfo key = Console.ReadKey(true);
            //switch (key.Key)
            //{
            //    case ConsoleKey.T:
            //        {
            //            UseItem();
            //            RemoveItemFromBackPack();
            //        }
            //        break;

            //    default:
            //}
        }


        // Skapa metod UseItem där vi får välja vilket item vi vill använda från vår backpack... när vi valt så anropar vi metoden GetEffect som är en virtual/override method
        // för de olika Items. Me ThunderHoney öka Health med Items damageboost... med InivisibilityCloak bli invisible.

        private void DisplayStats()
        {
            //int honeyCount = 0;
            //int cloakCount = 0;
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine();
            Console.WriteLine("Collected items:");
            Console.WriteLine("Press [U] to USE item.");
                
            foreach (var item in player.BackPack)
                Console.WriteLine($"{item.Key.Name}: {item.Value}");

            // Fixa senare.
            //Console.WriteLine($"Name: {defender.Name} Health: {defender.Health} Strength: {defender.Strength}");

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

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.U: ChooseItem(); break;
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
