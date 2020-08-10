using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class LoadBlock : Block
    {
        int width = 4;
        int height = 4;
        int blockElements = 4;

        int horizontal;
        int vertical;

        int[,] block;

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public int Horizontal { get => horizontal; set => horizontal = value; }
        public int Vertical { get => vertical; set => vertical = value; }

        public int[,] Block { get => block; set => block = value; }

        public LoadBlock()
        {

        }

        public LoadBlock(int _width, int _height, int _blockElements)
        {
            width = _width;
            height = _height;
            blockElements = _blockElements;
        }

        /// <summary>
        /// 새 블록을 생성합니다.
        /// </summary>
        public void CreateBlock()
        {
            block = CreateBlock(width, height);
        }

        /// <summary>
        /// LoadBlock이 바닥에 닿았는지를 판단합니다.
        /// </summary>
        /// <param name="filledBlocks"></param>
        /// <returns></returns>
        public bool BottomCollisionCheck(FilledBlocks filledBlocks)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (block[i, j] == 1)
                    {
                        if (filledBlocks.Blocks[i + horizontal + 1, j + vertical + 1] == 1)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// LoadBlock을 FillBlock에 추가합니다.
        /// </summary>
        /// <param name="filledBlocks"></param>
        public void AddFilledBlock(FilledBlocks filledBlocks)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (block[i, j] == 1)
                    {
                        filledBlocks.Blocks[i + horizontal + 1, j + vertical] = 1;
                    }
                }
            }
        }

        /// <summary>
        /// LoadBlock이 왼쪽으로 움직일 수 있는지 확인합니다.
        /// </summary>
        /// <param name="filledBlocks"></param>
        /// <returns></returns>
        public bool MoveLeftCheck(FilledBlocks filledBlocks)
        {
            int moveLeft = 0;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (block[i, j] == 1)
                    {
                        if (filledBlocks.Blocks[i + horizontal + 1 - 1, j + vertical] != 1)
                        {
                            moveLeft++;
                        }
                    }
                }
            }

            if (moveLeft == blockElements)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// LoadBlock이 오른쪽으로 움직일 수 있는지 확인합니다.
        /// </summary>
        /// <param name="filledBlocks"></param>
        /// <returns></returns>
        public bool MoveRightCheck(FilledBlocks filledBlocks)
        {
            int moveRight = 0;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (block[i, j] == 1)
                    {
                        if (filledBlocks.Blocks[i + horizontal + 1 + 1, j + vertical] != 1)
                        {
                            moveRight++;
                        }
                    }
                }
            }

            if (moveRight == blockElements)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// LoadBlock이 왼쪽으로 회전할 수 있는지 확인합니다.
        /// </summary>
        /// <param name="filledBlocks"></param>
        /// <returns></returns>
        public bool RotateLeftCheck(FilledBlocks filledBlocks)
        {
            int moveLeft = 0;
            int moveRight = 0;

            int[,] rotateCheckBlock = new int[width, height];

            rotateCheckBlock = RotateLeft(block);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (rotateCheckBlock[i, j] == 1)
                    {
                        if (filledBlocks.Blocks[i + horizontal + 1, j + vertical] != 1)
                        {
                            moveLeft++;
                        }
                    }
                }
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (rotateCheckBlock[i, j] == 1)
                    {
                        if (filledBlocks.Blocks[i + horizontal + 1, j + vertical] != 1)
                        {
                            moveRight++;
                        }
                    }
                }
            }

            if (moveLeft == blockElements && moveRight == blockElements)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// LoadBlock이 오른쪽으로 회전할 수 있는지 확인합니다.
        /// </summary>
        /// <param name="filledBlocks"></param>
        /// <returns></returns>
        public bool RotateRightCheck(FilledBlocks filledBlocks)
        {
            int moveLeft = 0;
            int moveRight = 0;

            int[,] rotateCheckBlock = new int[width, height];

            rotateCheckBlock = RotateRight(block);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (rotateCheckBlock[i, j] == 1)
                    {
                        //왼쪽에 벽이 없으면
                        if (filledBlocks.Blocks[i + horizontal + 1, j + vertical] != 1)
                        {
                            moveLeft++;
                        }
                    }
                }
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (rotateCheckBlock[i, j] == 1)
                    {
                        //오른쪽에 벽이 없으면
                        if (filledBlocks.Blocks[i + horizontal + 1, j + vertical] != 1)
                        {
                            moveRight++;
                        }
                    }
                }
            }

            if (moveLeft == blockElements && moveRight == blockElements)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 왼쪽으로 회전시킨 block을 반환합니다.
        /// </summary>
        /// <param name="block">왼쪽으로 회전시킬 block</param>
        /// <returns></returns>
        public int[,] RotateLeft(int[,] block)
        {
            int lengthY = block.GetLength(0);
            int lengthX = block.GetLength(1);

            int[,] result = new int[lengthX, lengthY];

            for (int y = 0; y < lengthY; y++)
            {
                for (int x = 0; x < lengthX; x++)
                {
                    result[x, y] = block[y, lengthX - 1 - x];
                }
            }

            return result;
        }

        /// <summary>
        /// 오른쪽으로 회전시킨 block을 반환합니다.
        /// </summary>
        /// <param name="block">오른쪽으로 회전시킬 block</param>
        /// <returns></returns>
        public int[,] RotateRight(int[,] block)
        {
            int lengthY = block.GetLength(0);
            int lengthX = block.GetLength(1);

            int[,] result = new int[lengthX, lengthY];

            for (int y = 0; y < lengthY; y++)
            {
                for (int x = 0; x < lengthX; x++)
                {
                    result[x, y] = block[lengthY - 1 - y, x];
                }
            }

            return result;
        }
    }
}
