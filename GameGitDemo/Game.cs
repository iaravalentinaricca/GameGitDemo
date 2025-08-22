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
            WriteLine("*** Welcome to the Game ***");

            Write("\nWhat is your name? ");
            string name = ReadLine();
            Player CurrentPlayer = new Player(name);
            WriteLine($"Let's get started {CurrentPlayer.Name}!");

            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }

    }
}
