using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GameGitDemo
{
    internal class Game
    {
        public void Run()
        {
            WriteLine("   ___    _     _         ___             \r\n  /___\\__| | __| |___    /___\\_ __  _ __  \r\n //  // _` |/ _` / __|  //  // '_ \\| '_ \\ \r\n/ \\_// (_| | (_| \\__ \\ / \\_//| | | | | | |\r\n\\___/ \\__,_|\\__,_|___/ \\___/ |_| |_|_| |_|\r\n                                          ");
            WriteLine("*** Welcome to the Game: " +
                "Odds On! ***");


            Write("\nWhat is your name? ");
            string name = ReadLine();
            Player CurrentPlayer = new Player(name);
            WriteLine($"Let's get started {CurrentPlayer.Name}!");

            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }

    }
}
