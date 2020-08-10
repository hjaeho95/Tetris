using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class InfoBoard
    {
        int score;
        int level;

        public InfoBoard(int _level)
        {
            level = _level;
        }

        public int Score { get => score; set => score = value; }
        public int Level { get => level; set => level = value; }
    }
}
