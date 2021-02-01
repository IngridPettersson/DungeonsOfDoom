using System;

namespace DungeonsOfDoom
{

    // Världen skapas en gång (CreateWorld())
    // -
    // if statement efter switch statement när man tryckt på knapp, kontrollerar så att newX och newY är över 0 och mindre än world (Room[,]) längd då respektive axel.
    // spelplanen ritas upp efter varje knapptryck
    // health blir 0, då avslutas spelet (do while loop i ConsoleGame)
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleGame game = new ConsoleGame();
            game.Play();
        }
    }
}
