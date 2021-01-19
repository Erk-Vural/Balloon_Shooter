using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brave_Archer
{
    class Player
    {
        public int Score;
        public int Level;
        public bool pause;
        public bool gameIsOver;
        public int arrowLeft;

        public Player()
        {
            Score = 0;
            Level = 1;
            pause = false;
            gameIsOver = false;
            arrowLeft = 50;
        }
    }
}
