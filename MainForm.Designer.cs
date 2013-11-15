namespace Boggle
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.WordListTextBox = new System.Windows.Forms.TextBox();
            this.ShakeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.RotateLeftButton = new System.Windows.Forms.Button();
            this.RotateRightButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miSet = new System.Windows.Forms.ToolStripMenuItem();
            this.miClassic = new System.Windows.Forms.ToolStripMenuItem();
            this.miModern = new System.Windows.Forms.ToolStripMenuItem();
            this.miBig = new System.Windows.Forms.ToolStripMenuItem();
            this.miSuperBig = new System.Windows.Forms.ToolStripMenuItem();
            this.SetNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(288, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 220);
            this.panel1.TabIndex = 0;
            // 
            // WordListTextBox
            // 
            this.WordListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordListTextBox.Location = new System.Drawing.Point(16, 88);
            this.WordListTextBox.Multiline = true;
            this.WordListTextBox.Name = "WordListTextBox";
            this.WordListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WordListTextBox.Size = new System.Drawing.Size(240, 316);
            this.WordListTextBox.TabIndex = 1;
            this.WordListTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WordListTextBox_KeyUp);
            // 
            // ShakeButton
            // 
            this.ShakeButton.Location = new System.Drawing.Point(96, 416);
            this.ShakeButton.Name = "ShakeButton";
            this.ShakeButton.Size = new System.Drawing.Size(75, 56);
            this.ShakeButton.TabIndex = 2;
            this.ShakeButton.Text = "&Shake";
            this.ShakeButton.UseVisualStyleBackColor = true;
            this.ShakeButton.Click += new System.EventHandler(this.ShakeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(40, 32);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(176, 52);
            this.TimerLabel.TabIndex = 3;
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreButton
            // 
            this.ScoreButton.Enabled = false;
            this.ScoreButton.Location = new System.Drawing.Point(96, 416);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(75, 56);
            this.ScoreButton.TabIndex = 4;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            this.ScoreButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(176, 416);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 56);
            this.DoneButton.TabIndex = 5;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Visible = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Enabled = false;
            this.NewGameButton.Location = new System.Drawing.Point(16, 416);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(75, 56);
            this.NewGameButton.TabIndex = 6;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Visible = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // RotateLeftButton
            // 
            this.RotateLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("RotateLeftButton.Image")));
            this.RotateLeftButton.Location = new System.Drawing.Point(288, 88);
            this.RotateLeftButton.Name = "RotateLeftButton";
            this.RotateLeftButton.Size = new System.Drawing.Size(40, 40);
            this.RotateLeftButton.TabIndex = 7;
            this.RotateLeftButton.UseVisualStyleBackColor = true;
            this.RotateLeftButton.Click += new System.EventHandler(this.RotateLeftButton_Click);
            // 
            // RotateRightButton
            // 
            this.RotateRightButton.Image = ((System.Drawing.Image)(resources.GetObject("RotateRightButton.Image")));
            this.RotateRightButton.Location = new System.Drawing.Point(336, 88);
            this.RotateRightButton.Name = "RotateRightButton";
            this.RotateRightButton.Size = new System.Drawing.Size(40, 40);
            this.RotateRightButton.TabIndex = 8;
            this.RotateRightButton.UseVisualStyleBackColor = true;
            this.RotateRightButton.Click += new System.EventHandler(this.RotateRightButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSet});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miSet
            // 
            this.miSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClassic,
            this.miModern,
            this.miBig,
            this.miSuperBig});
            this.miSet.Name = "miSet";
            this.miSet.Size = new System.Drawing.Size(35, 20);
            this.miSet.Text = "Set";
            // 
            // miClassic
            // 
            this.miClassic.CheckOnClick = true;
            this.miClassic.Name = "miClassic";
            this.miClassic.Size = new System.Drawing.Size(164, 22);
            this.miClassic.Tag = "Classic";
            this.miClassic.Text = "Classic Boggle";
            this.miClassic.CheckedChanged += new System.EventHandler(this.AnySetMenuItem_CheckedChanged);
            // 
            // miModern
            // 
            this.miModern.Checked = true;
            this.miModern.CheckOnClick = true;
            this.miModern.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miModern.Name = "miModern";
            this.miModern.Size = new System.Drawing.Size(164, 22);
            this.miModern.Tag = "Modern";
            this.miModern.Text = "Modern Boggle";
            this.miModern.CheckedChanged += new System.EventHandler(this.AnySetMenuItem_CheckedChanged);
            // 
            // miBig
            // 
            this.miBig.CheckOnClick = true;
            this.miBig.Name = "miBig";
            this.miBig.Size = new System.Drawing.Size(164, 22);
            this.miBig.Tag = "Big";
            this.miBig.Text = "Big Boggle";
            this.miBig.CheckedChanged += new System.EventHandler(this.AnySetMenuItem_CheckedChanged);
            // 
            // miSuperBig
            // 
            this.miSuperBig.CheckOnClick = true;
            this.miSuperBig.Enabled = false;
            this.miSuperBig.Name = "miSuperBig";
            this.miSuperBig.Size = new System.Drawing.Size(164, 22);
            this.miSuperBig.Tag = "SuperBig";
            this.miSuperBig.Text = "Super Big Boggle";
            this.miSuperBig.CheckedChanged += new System.EventHandler(this.AnySetMenuItem_CheckedChanged);
            // 
            // SetNameLabel
            // 
            this.SetNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetNameLabel.Location = new System.Drawing.Point(288, 32);
            this.SetNameLabel.Name = "SetNameLabel";
            this.SetNameLabel.Size = new System.Drawing.Size(328, 44);
            this.SetNameLabel.TabIndex = 10;
            this.SetNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 488);
            this.Controls.Add(this.SetNameLabel);
            this.Controls.Add(this.RotateRightButton);
            this.Controls.Add(this.RotateLeftButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.WordListTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ShakeButton);
            this.Controls.Add(this.ScoreButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Boggle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox WordListTextBox;
        private System.Windows.Forms.Button ShakeButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button ScoreButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button RotateLeftButton;
        private System.Windows.Forms.Button RotateRightButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miSet;
        private System.Windows.Forms.ToolStripMenuItem miClassic;
        private System.Windows.Forms.ToolStripMenuItem miModern;
        private System.Windows.Forms.ToolStripMenuItem miBig;
        private System.Windows.Forms.ToolStripMenuItem miSuperBig;
        private System.Windows.Forms.Label SetNameLabel;
    }
}

