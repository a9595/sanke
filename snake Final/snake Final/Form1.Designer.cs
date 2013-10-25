namespace snake
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerSnake = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LifesStatusImg = new System.Windows.Forms.ToolStripStatusLabel();
            this.LifesStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BombsCountStatusImg = new System.Windows.Forms.ToolStripStatusLabel();
            this.BombsCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ApplesCountStatusImg = new System.Windows.Forms.ToolStripStatusLabel();
            this.ApplesCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.likeAProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applesCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Aplles5toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Aplles10toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Aplles15toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.bombsCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bombs5toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.Bombs10toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.Bombs15toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.ScoresStringStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ScoresCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSnake
            // 
            this.timerSnake.Interval = 300;
            this.timerSnake.Tick += new System.EventHandler(this.timerSnake_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LifesStatusImg,
            this.LifesStatusLabel,
            this.BombsCountStatusImg,
            this.BombsCountStatusLabel,
            this.ApplesCountStatusImg,
            this.ApplesCountStatusLabel,
            this.ScoresStringStatusLabel,
            this.ScoresCountStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(602, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LifesStatusImg
            // 
            this.LifesStatusImg.BackgroundImage = global::snake.Properties.Resources.HeartIcon;
            this.LifesStatusImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LifesStatusImg.Name = "LifesStatusImg";
            this.LifesStatusImg.Size = new System.Drawing.Size(22, 17);
            this.LifesStatusImg.Text = "     ";
            this.LifesStatusImg.ToolTipText = "Lifes Count";
            // 
            // LifesStatusLabel
            // 
            this.LifesStatusLabel.Name = "LifesStatusLabel";
            this.LifesStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.LifesStatusLabel.Text = "3";
            this.LifesStatusLabel.ToolTipText = "Lifes Count";
            // 
            // BombsCountStatusImg
            // 
            this.BombsCountStatusImg.AutoToolTip = true;
            this.BombsCountStatusImg.BackgroundImage = global::snake.Properties.Resources.BombIcon;
            this.BombsCountStatusImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BombsCountStatusImg.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.BombsCountStatusImg.Name = "BombsCountStatusImg";
            this.BombsCountStatusImg.Size = new System.Drawing.Size(22, 17);
            this.BombsCountStatusImg.Text = "     ";
            this.BombsCountStatusImg.ToolTipText = "Bombs Count";
            // 
            // BombsCountStatusLabel
            // 
            this.BombsCountStatusLabel.Name = "BombsCountStatusLabel";
            this.BombsCountStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.BombsCountStatusLabel.Text = "5";
            this.BombsCountStatusLabel.ToolTipText = "Bombs Count";
            // 
            // ApplesCountStatusImg
            // 
            this.ApplesCountStatusImg.BackgroundImage = global::snake.Properties.Resources.AppleIcon;
            this.ApplesCountStatusImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ApplesCountStatusImg.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.ApplesCountStatusImg.Name = "ApplesCountStatusImg";
            this.ApplesCountStatusImg.Size = new System.Drawing.Size(19, 17);
            this.ApplesCountStatusImg.Text = "    ";
            this.ApplesCountStatusImg.ToolTipText = "Apples Count";
            // 
            // ApplesCountStatusLabel
            // 
            this.ApplesCountStatusLabel.AutoToolTip = true;
            this.ApplesCountStatusLabel.Name = "ApplesCountStatusLabel";
            this.ApplesCountStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.ApplesCountStatusLabel.Text = "0";
            this.ApplesCountStatusLabel.ToolTipText = "Apples Eated";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.levelToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginnerToolStripMenuItem,
            this.amatureToolStripMenuItem,
            this.likeAProToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.levelToolStripMenuItem.Text = "Level";
            // 
            // beginnerToolStripMenuItem
            // 
            this.beginnerToolStripMenuItem.Checked = true;
            this.beginnerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.beginnerToolStripMenuItem.Name = "beginnerToolStripMenuItem";
            this.beginnerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.beginnerToolStripMenuItem.Text = "Beginner";
            this.beginnerToolStripMenuItem.Click += new System.EventHandler(this.ItemsToRadioCheckedToolStripMenuItem_Click);
            // 
            // amatureToolStripMenuItem
            // 
            this.amatureToolStripMenuItem.Name = "amatureToolStripMenuItem";
            this.amatureToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.amatureToolStripMenuItem.Text = "Amature";
            this.amatureToolStripMenuItem.Click += new System.EventHandler(this.ItemsToRadioCheckedToolStripMenuItem_Click);
            // 
            // likeAProToolStripMenuItem
            // 
            this.likeAProToolStripMenuItem.Name = "likeAProToolStripMenuItem";
            this.likeAProToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.likeAProToolStripMenuItem.Text = "Like a Pro";
            this.likeAProToolStripMenuItem.Click += new System.EventHandler(this.ItemsToRadioCheckedToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applesCountToolStripMenuItem,
            this.bombsCountToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // applesCountToolStripMenuItem
            // 
            this.applesCountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Aplles5toolStripMenuItem2,
            this.Aplles10toolStripMenuItem3,
            this.Aplles15toolStripMenuItem4});
            this.applesCountToolStripMenuItem.Image = global::snake.Properties.Resources.AppleIcon;
            this.applesCountToolStripMenuItem.Name = "applesCountToolStripMenuItem";
            this.applesCountToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.applesCountToolStripMenuItem.Text = "Apples count";
            // 
            // Aplles5toolStripMenuItem2
            // 
            this.Aplles5toolStripMenuItem2.Checked = true;
            this.Aplles5toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Aplles5toolStripMenuItem2.Name = "Aplles5toolStripMenuItem2";
            this.Aplles5toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.Aplles5toolStripMenuItem2.Text = "5";
            this.Aplles5toolStripMenuItem2.Click += new System.EventHandler(this.ItemsToRadioCheckedToolStripMenuItem_Click);
            // 
            // Aplles10toolStripMenuItem3
            // 
            this.Aplles10toolStripMenuItem3.Name = "Aplles10toolStripMenuItem3";
            this.Aplles10toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.Aplles10toolStripMenuItem3.Text = "10";
            this.Aplles10toolStripMenuItem3.Click += new System.EventHandler(this.ItemsToRadioCheckedToolStripMenuItem_Click);
            // 
            // Aplles15toolStripMenuItem4
            // 
            this.Aplles15toolStripMenuItem4.Name = "Aplles15toolStripMenuItem4";
            this.Aplles15toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.Aplles15toolStripMenuItem4.Text = "15";
            this.Aplles15toolStripMenuItem4.Click += new System.EventHandler(this.ItemsToRadioCheckedToolStripMenuItem_Click);
            // 
            // bombsCountToolStripMenuItem
            // 
            this.bombsCountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bombs5toolStripMenuItem5,
            this.Bombs10toolStripMenuItem6,
            this.Bombs15toolStripMenuItem7});
            this.bombsCountToolStripMenuItem.Image = global::snake.Properties.Resources.BombIcon;
            this.bombsCountToolStripMenuItem.Name = "bombsCountToolStripMenuItem";
            this.bombsCountToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.bombsCountToolStripMenuItem.Text = "Bombs count";
            // 
            // Bombs5toolStripMenuItem5
            // 
            this.Bombs5toolStripMenuItem5.Checked = true;
            this.Bombs5toolStripMenuItem5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Bombs5toolStripMenuItem5.Name = "Bombs5toolStripMenuItem5";
            this.Bombs5toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.Bombs5toolStripMenuItem5.Text = "5";
            this.Bombs5toolStripMenuItem5.Click += new System.EventHandler(this.ItemsToRadioCheckedToolStripMenuItem_Click);
            // 
            // Bombs10toolStripMenuItem6
            // 
            this.Bombs10toolStripMenuItem6.Name = "Bombs10toolStripMenuItem6";
            this.Bombs10toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.Bombs10toolStripMenuItem6.Text = "10";
            this.Bombs10toolStripMenuItem6.Click += new System.EventHandler(this.ItemsToRadioCheckedToolStripMenuItem_Click);
            // 
            // Bombs15toolStripMenuItem7
            // 
            this.Bombs15toolStripMenuItem7.Name = "Bombs15toolStripMenuItem7";
            this.Bombs15toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.Bombs15toolStripMenuItem7.Text = "15";
            this.Bombs15toolStripMenuItem7.Click += new System.EventHandler(this.ItemsToRadioCheckedToolStripMenuItem_Click);
            // 
            // ScoresStringStatusLabel
            // 
            this.ScoresStringStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoresStringStatusLabel.Margin = new System.Windows.Forms.Padding(50, 3, 0, 2);
            this.ScoresStringStatusLabel.Name = "ScoresStringStatusLabel";
            this.ScoresStringStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.ScoresStringStatusLabel.Text = "Scores: ";
            // 
            // ScoresCountStatusLabel
            // 
            this.ScoresCountStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoresCountStatusLabel.Name = "ScoresCountStatusLabel";
            this.ScoresCountStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.ScoresCountStatusLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::snake.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 651);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake by Andriy Kovalchuk";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerSnake;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LifesStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem likeAProToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applesCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bombsCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel LifesStatusImg;
        private System.Windows.Forms.ToolStripStatusLabel BombsCountStatusImg;
        private System.Windows.Forms.ToolStripStatusLabel BombsCountStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ApplesCountStatusImg;
        private System.Windows.Forms.ToolStripStatusLabel ApplesCountStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem Aplles5toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Aplles10toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Aplles15toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem Bombs5toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem Bombs10toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem Bombs15toolStripMenuItem7;
        private System.Windows.Forms.ToolStripStatusLabel ScoresStringStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ScoresCountStatusLabel;
    }
}

