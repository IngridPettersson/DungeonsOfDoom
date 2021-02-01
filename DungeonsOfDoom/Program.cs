using System;

namespace DungeonsOfDoom
{

    // Världen skapas en gång (CreateWorld())
    // -
    // if statement efter switch statement när man tryckt på knapp.
    // spelplanen ritas upp efter varje förflyttning (eller efter varje knapptryck?)
    // health blir 0, då avslutas spelet
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleGame game = new ConsoleGame();
            game.Play();
        }
    }
}
