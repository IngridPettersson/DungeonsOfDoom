using System;

namespace DungeonsOfDoom
{

    // Skapa en basklass som innehåller allt som är gemensamt mellan spelare och monster.
    // Implementera ett till arv, tex två subklasser till Monster eller Item.
    // Se till att era klasser har lämpliga constructors.
    // Se till att alla klasser som uteslutande ska ärvas från är markerade som abstrakta.

    // Om tid finns: lägg till ett par egna properties för att göra spelet roligare :)

    // Världen skapas en gång (CreateWorld())
    // Inväntar ett movement från användaren, alltså ett tangenttryck (Console.ReadKey()).
    // if statement efter switch statement när man tryckt på tangent, kontrollerar så att newX och newY är över 0 och mindre än world (Room[,]) längd då respektive axel.
    // spelplanen ritas upp efter varje tangenttryck
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
