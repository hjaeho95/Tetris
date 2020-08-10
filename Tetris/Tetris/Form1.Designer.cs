namespace Tetris
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.난이도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EasyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.LevelViewLabel = new System.Windows.Forms.Label();
            this.ScoreViewLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.NextLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(549, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.FileToolStripMenuItem.Text = "파일";
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.NewGameToolStripMenuItem.Text = "새 게임";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.CloseToolStripMenuItem.Text = "종료";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.난이도ToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.SettingsToolStripMenuItem.Text = "설정";
            // 
            // 난이도ToolStripMenuItem
            // 
            this.난이도ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HardToolStripMenuItem,
            this.MediumToolStripMenuItem,
            this.EasyToolStripMenuItem});
            this.난이도ToolStripMenuItem.Name = "난이도ToolStripMenuItem";
            this.난이도ToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.난이도ToolStripMenuItem.Text = "난이도";
            // 
            // HardToolStripMenuItem
            // 
            this.HardToolStripMenuItem.Name = "HardToolStripMenuItem";
            this.HardToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.HardToolStripMenuItem.Text = "고급";
            this.HardToolStripMenuItem.Click += new System.EventHandler(this.HardToolStripMenuItem_Click);
            // 
            // MediumToolStripMenuItem
            // 
            this.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem";
            this.MediumToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.MediumToolStripMenuItem.Text = "중급";
            this.MediumToolStripMenuItem.Click += new System.EventHandler(this.MediumToolStripMenuItem_Click);
            // 
            // EasyToolStripMenuItem
            // 
            this.EasyToolStripMenuItem.Checked = true;
            this.EasyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem";
            this.EasyToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.EasyToolStripMenuItem.Text = "초급";
            this.EasyToolStripMenuItem.Click += new System.EventHandler(this.EasyToolStripMenuItem_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePanel.Location = new System.Drawing.Point(17, 42);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(303, 634);
            this.GamePanel.TabIndex = 1;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoPanel.Controls.Add(this.LevelViewLabel);
            this.InfoPanel.Controls.Add(this.ScoreViewLabel);
            this.InfoPanel.Controls.Add(this.LevelLabel);
            this.InfoPanel.Controls.Add(this.ScoreLabel);
            this.InfoPanel.Controls.Add(this.NextLabel);
            this.InfoPanel.Location = new System.Drawing.Point(354, 42);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(176, 634);
            this.InfoPanel.TabIndex = 2;
            // 
            // LevelViewLabel
            // 
            this.LevelViewLabel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LevelViewLabel.Location = new System.Drawing.Point(4, 580);
            this.LevelViewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelViewLabel.Name = "LevelViewLabel";
            this.LevelViewLabel.Size = new System.Drawing.Size(166, 30);
            this.LevelViewLabel.TabIndex = 4;
            this.LevelViewLabel.Text = "-";
            this.LevelViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreViewLabel
            // 
            this.ScoreViewLabel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScoreViewLabel.Location = new System.Drawing.Point(4, 480);
            this.ScoreViewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreViewLabel.Name = "ScoreViewLabel";
            this.ScoreViewLabel.Size = new System.Drawing.Size(166, 30);
            this.ScoreViewLabel.TabIndex = 3;
            this.ScoreViewLabel.Text = "-";
            this.ScoreViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelLabel
            // 
            this.LevelLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LevelLabel.Location = new System.Drawing.Point(4, 540);
            this.LevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(166, 30);
            this.LevelLabel.TabIndex = 2;
            this.LevelLabel.Text = "LEVEL";
            this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScoreLabel.Location = new System.Drawing.Point(4, 440);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(166, 30);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "SCORE";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextLabel
            // 
            this.NextLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NextLabel.Location = new System.Drawing.Point(4, 30);
            this.NextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NextLabel.Name = "NextLabel";
            this.NextLabel.Size = new System.Drawing.Size(166, 30);
            this.NextLabel.TabIndex = 0;
            this.NextLabel.Text = "NEXT";
            this.NextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(549, 692);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "테트리스";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 난이도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EasyToolStripMenuItem;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label LevelViewLabel;
        private System.Windows.Forms.Label ScoreViewLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label NextLabel;
    }
}

