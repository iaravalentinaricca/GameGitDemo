using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGitDemo
{
    internal class Player
    {
        new Player player;
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

    }
}
