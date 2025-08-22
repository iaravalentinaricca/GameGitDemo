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

            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }

    }
}
