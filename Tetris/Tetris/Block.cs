using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Block
    {
        int randomHelp = 0;

        /// <summary>
        /// 7가지 블록 중 랜덤하게 만들어진 블록을 반환합니다.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public int[,] CreateBlock(int width, int height)
        {
            int[,] createBlock = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    createBlock[i, j] = 0;
                }
            }

            Random random = new Random();

            int a = (random.Next() + randomHelp) % 7;

            randomHelp++;

            //■ ■ ■ ■
            if (a == 0)
            {
                createBlock[0, 2] = 1;
                createBlock[1, 2] = 1;
                createBlock[2, 2] = 1;
                createBlock[3, 2] = 1;
            }
            //■ ■
            //■ ■
            else if (a == 1)
            {
                createBlock[1, 1] = 1;
                createBlock[2, 1] = 1;
                createBlock[1, 2] = 1;
                createBlock[2, 2] = 1;
            }
            //■ ■
            //  ■ ■
            else if (a == 2)
            {
                createBlock[0, 1] = 1;
                createBlock[1, 1] = 1;
                createBlock[1, 2] = 1;
                createBlock[2, 2] = 1;
            }
            //  ■ ■
            //■ ■
            else if (a == 3)
            {
                createBlock[1, 1] = 1;
                createBlock[2, 1] = 1;
                createBlock[0, 2] = 1;
                createBlock[1, 2] = 1;
            }
            //■
            //■ ■ ■
            else if (a == 4)
            {
                createBlock[0, 1] = 1;
                createBlock[0, 2] = 1;
                createBlock[1, 2] = 1;
                createBlock[2, 2] = 1;
            }
            //    ■
            //■ ■ ■
            else if (a == 5)
            {
                createBlock[2, 1] = 1;
                createBlock[0, 2] = 1;
                createBlock[1, 2] = 1;
                createBlock[2, 2] = 1;
            }
            //■ ■ ■
            //  ■
            else if (a == 6)
            {
                createBlock[0, 1] = 1;
                createBlock[1, 1] = 1;
                createBlock[2, 1] = 1;
                createBlock[1, 2] = 1;
            }

            return createBlock;
        }
    }
}
