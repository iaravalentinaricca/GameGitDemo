using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            WriteLine("*** Welcome to the Game ***");

            Write("\nPlayer 1, what is your name? ");
            string name = ReadLine();
            Player player = new Player(name);
            Clear();

            
        }

        public void GameStart()
        {
           

        }

        public void EndofGame()
        { 
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }

    }
    
    
}
