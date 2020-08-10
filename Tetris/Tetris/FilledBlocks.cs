using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class FilledBlocks : Block
    {
        int width = 12;
        int height = 23;

        int[,] blocks;

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public int[,] Blocks { get => blocks; set => blocks = value; }

        /// <summary>
        /// 초기상태의 FilledBlocks를 구성합니다.
        /// </summary>
        public void InitStateBlocks()
        {
            blocks = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    //바닥 채워주기
                    if (j == height - 1)
                    {
                        blocks[i, j] = 1;
                    }
                    //왼벽, 오른벽 채워주기
                    else if (i == 0 || i == width - 1)
                    {
                        blocks[i, j] = 1;
                    }
                    //나머지는 빈칸
                    else
                    {
                        blocks[i, j] = 0;
                    }
                }
            }
        }
        
        /// <summary>
        /// 지워질 Row를 확인합니다.
        /// </summary>
        /// <param name="deleteRowCnt">지워진 Row의 수를 반환</param>
        /// <returns></returns>
        public bool DelFilledBlocks(out int deleteRowCnt)
        {
            int fillCheck = 0;

            List<int> deleteRow = new List<int>();

            int firstRow = 0;
            int lastRow = 0;

            //지워질 줄이 있는지 확인해 변수에 값 저장
            for (int j = 2; j < height - 1; j++)
            {
                for (int i = 1; i < width - 1; i++)
                {
                    if (blocks[i, j] == 1)
                    {
                        fillCheck++;
                    }

                    if (fillCheck == 10)
                    {
                        deleteRow.Add(j);
                        break;
                    }
                }
                fillCheck = 0;
            }

            deleteRowCnt = deleteRow.Count;

            //지워질 줄이 있으면
            if (deleteRow.Count > 0)
            {
                firstRow = deleteRow[0];
                lastRow = deleteRow[deleteRow.Count - 1];

                foreach (int idx in deleteRow)
                {
                    for (int i = 1; i < width - 1; i++)
                    {
                        blocks[i, idx] = 0;
                    }
                }

                for (int j = firstRow - 1; j > 1; j--)
                {
                    for (int i = 1; i < width - 1; i++)
                    {
                        if (blocks[i, j] == 1)
                        {
                            blocks[i, j + (lastRow - firstRow + 1)] = 1;
                            blocks[i, j] = 0;
                        }
                    }
                }
                return true;
            }

            return false;
        }

        /// <summary>
        /// FilledBlocks의 최상단에 블록이 있는지 확인합니다.
        /// </summary>
        /// <returns></returns>
        public bool TopCollisionCheck()
        {
            for (int i = 1; i < width - 1; i++)
            {
                if (blocks[i, 2] == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
