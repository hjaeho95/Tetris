using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class NextBlock : Block
    {
        int width = 4;
        int height = 4;
        int blockElements = 4;

        int[,] block;

        public NextBlock()
        {

        }

        public NextBlock(int _width, int _height, int _blockElements)
        {
            width = _width;
            height = _height;
            blockElements = _blockElements;
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public int[,] Block { get => block; set => block = value; }

        /// <summary>
        /// 새 블록을 생성합니다.
        /// </summary>
        public void CreateBlock()
        {
            block = CreateBlock(width, height);
        }
    }
}
