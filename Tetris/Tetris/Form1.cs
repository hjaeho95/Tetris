using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        enum Horizontal : int
        {
            Center = 3
        }

        enum Vertical
        {
            Top = 0
        }

        enum Level
        {
            Easy = 1,
            Medium = 3,
            Hard = 5
        }

        InfoBoard infoBoard = new InfoBoard((int)Level.Easy);

        NextBlock nextBlock = new NextBlock();
        LoadBlock loadBlock = new LoadBlock();
        FilledBlocks filledBlocks = new FilledBlocks();

        bool gameStart = false;

        Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameStart)
            {
                //키보드 EXC 키 입력
                if (e.KeyCode == Keys.Escape)
                {
                    Close();
                }

                //키보드 왼쪽 방향키 입력
                if (e.KeyCode == Keys.Left)
                {
                    try
                    {
                        if (loadBlock.MoveLeftCheck(filledBlocks))
                        {
                            loadBlock.Horizontal--;

                            DrawBlocks();
                        }
                    }
                    catch
                    {

                    }
                }

                //키보드 오른쪽 방향키 입력
                if (e.KeyCode == Keys.Right)
                {
                    try
                    {
                        if (loadBlock.MoveRightCheck(filledBlocks))
                        {
                            loadBlock.Horizontal++;

                            DrawBlocks();
                        }
                    }
                    catch
                    {

                    }
                }

                //키보드 아래쪽 방향키 입력
                if (e.KeyCode == Keys.Down)
                {
                    try
                    {
                        if (loadBlock.BottomCollisionCheck(filledBlocks))
                        {
                            RebuildBlocks();

                            GameOverCheck();
                        }
                        else
                        {
                            loadBlock.Vertical++;

                            DrawBlocks();
                        }
                    }
                    catch
                    {

                    }
                }

                //키보드 스페이스키 입력
                if (e.KeyCode == Keys.Space)
                {
                    try
                    {
                        while (true)
                        {
                            if (loadBlock.BottomCollisionCheck(filledBlocks))
                            {
                                break;
                            }
                            else
                            {
                                loadBlock.Vertical++;
                            }
                        }

                        RebuildBlocks();

                        GameOverCheck();
                    }
                    catch
                    {

                    }
                }

                //키보드 Z키 입력
                if (e.KeyCode == Keys.Z)
                {
                    try
                    {
                        if (loadBlock.RotateLeftCheck(filledBlocks))
                        {
                            loadBlock.Block = loadBlock.RotateLeft(loadBlock.Block);

                            DrawBlocks();
                        }
                    }
                    catch
                    {

                    }
                }

                //키보드 X키 입력
                if (e.KeyCode == Keys.X)
                {
                    try
                    {
                        if (loadBlock.RotateRightCheck(filledBlocks))
                        {
                            loadBlock.Block = loadBlock.RotateRight(loadBlock.Block);

                            DrawBlocks();
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (infoBoard.Level == (int)Level.Easy)
            {
                LevelViewLabel.Text = EasyToolStripMenuItem.Text;
            }
            else if (infoBoard.Level == (int)Level.Medium)
            {
                LevelViewLabel.Text = MediumToolStripMenuItem.Text;
            }
            else if (infoBoard.Level == (int)Level.Hard)
            {
                LevelViewLabel.Text = HardToolStripMenuItem.Text;
            }

            infoBoard.Score = 0;

            ScoreViewLabel.Text = infoBoard.Score.ToString();

            GameStartCheck();

            loadBlock.CreateBlock();

            nextBlock.CreateBlock();

            DrawNextBlock();

            DrawBackground();

            DrawFilledBlocks();

            DrawLoadBlock();

            if (timer != null)
            {
                timer.Stop();
            }

            timer = new Timer();
            timer.Interval = 1000 / infoBoard.Level;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoBoard.Level = (int)Level.Easy;

            EasyToolStripMenuItem.Checked = true;
            MediumToolStripMenuItem.Checked = false;
            HardToolStripMenuItem.Checked = false;
        }

        private void MediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoBoard.Level = (int)Level.Medium;

            EasyToolStripMenuItem.Checked = false;
            MediumToolStripMenuItem.Checked = true;
            HardToolStripMenuItem.Checked = false;
        }

        private void HardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoBoard.Level = (int)Level.Hard;

            EasyToolStripMenuItem.Checked = false;
            MediumToolStripMenuItem.Checked = false;
            HardToolStripMenuItem.Checked = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (loadBlock.BottomCollisionCheck(filledBlocks))
            {
                RebuildBlocks();

                GameOverCheck();
            }
            else
            {
                loadBlock.Vertical++;

                DrawBlocks();
            }
        }

        /// <summary>
        /// NextBlock를 InfoPanel에 그립니다.
        /// </summary>
        private void DrawNextBlock()
        {
            for (int i = 0; i < nextBlock.Width; i++)
            {
                for (int j = 0; j < nextBlock.Height; j++)
                {
                    Graphics graphics = InfoPanel.CreateGraphics();
                    if (nextBlock.Block[i, j] == 1)
                    {
                        Brush brush = new System.Drawing.SolidBrush(Color.Gray);
                        Rectangle Rectangle_Frame = new Rectangle(19 + i + (i * 20), 61 + j + (j * 20), 20, 20); ;
                        graphics.FillRectangle(brush, Rectangle_Frame);
                        brush.Dispose();
                        graphics.Dispose();
                    }
                    else
                    {
                        Brush brush = new System.Drawing.SolidBrush(Color.LightGray);
                        Rectangle Rectangle_Frame = new Rectangle(19 + i + (i * 20), 61 + j + (j * 20), 20, 20); ;
                        graphics.FillRectangle(brush, Rectangle_Frame);
                        brush.Dispose();
                        graphics.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// GamePanel을 다시 그립니다.
        /// </summary>
        private void DrawBlocks()
        {
            DrawBackground();
            DrawFilledBlocks();
            DrawLoadBlock();
        }

        //빈 배경 그리기
        private void DrawBackground()
        {
            for (int i = 0; i < filledBlocks.Width - 2; i++)
            {
                for (int j = 0; j < filledBlocks.Height - 3; j++)
                {
                    Graphics graphics = GamePanel.CreateGraphics();
                    Brush brush = new System.Drawing.SolidBrush(Color.LightGray);
                    Rectangle Rectangle_Frame = new Rectangle(1 + i + (i * 20), 1 + j + (j * 20), 20, 20); ;
                    graphics.FillRectangle(brush, Rectangle_Frame);
                    brush.Dispose();
                    graphics.Dispose();
                }
            }
        }

        //FilledBlocks 그리기
        private void DrawFilledBlocks()
        {
            for (int i = 1; i < filledBlocks.Width - 1; i++)
            {
                for (int j = 2; j < filledBlocks.Height - 1; j++)
                {
                    if (filledBlocks.Blocks[i, j] == 1)
                    {
                        Graphics graphics = GamePanel.CreateGraphics();
                        Brush brush = new System.Drawing.SolidBrush(Color.Gray);
                        Rectangle Rectangle_Frame = new Rectangle(1 + i + (i * 20) - 21, 1 + j + (j * 20) - 42, 20, 20); ;
                        graphics.FillRectangle(brush, Rectangle_Frame);
                        brush.Dispose();
                        graphics.Dispose();
                    }
                }
            }
        }

        //LoadBlock 그리기
        private void DrawLoadBlock()
        {
            for (int i = 0; i < loadBlock.Width; i++)
            {
                for (int j = 0; j < loadBlock.Height; j++)
                {
                    if (loadBlock.Block[i, j] == 1)
                    {
                        Graphics graphics = GamePanel.CreateGraphics();
                        Brush brush = new System.Drawing.SolidBrush(Color.LightSlateGray);
                        Rectangle Rectangle_Frame = new Rectangle(1 + i + loadBlock.Horizontal + ((i + loadBlock.Horizontal) * 20), -41 + j + loadBlock.Vertical + ((j + loadBlock.Vertical) * 20), 20, 20); ;
                        graphics.FillRectangle(brush, Rectangle_Frame);
                        brush.Dispose();
                        graphics.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// 블록을 재건합니다.
        /// </summary>
        private void RebuildBlocks()
        {
            loadBlock.AddFilledBlock(filledBlocks);

            if (filledBlocks.DelFilledBlocks(out int deleteRowCnt))
            {
                infoBoard.Score += Convert.ToInt32(Math.Pow(deleteRowCnt, 2)) * 10;

                ScoreViewLabel.Text = infoBoard.Score.ToString();
            }

            loadBlock.Block = nextBlock.Block;

            nextBlock.CreateBlock();

            DrawNextBlock();

            loadBlock.Horizontal = (int)Horizontal.Center;
            loadBlock.Vertical = (int)Vertical.Top;

            DrawBlocks();
        }

        /// <summary>
        /// 게임시작 확인 및 초기상태를 구성합니다.
        /// </summary>
        private void GameStartCheck()
        {
            loadBlock.Horizontal = (int)Horizontal.Center;
            loadBlock.Vertical = (int)Vertical.Top;

            filledBlocks.InitStateBlocks();

            gameStart = true;
        }

        /// <summary>
        /// 게임오버를 확인합니다.
        /// </summary>
        private void GameOverCheck()
        {
            if (filledBlocks.TopCollisionCheck())
            {
                timer.Stop();

                gameStart = false;

                //게임오버
                MessageBox.Show("GameOver");
            }
        }
    }
}