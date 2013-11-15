namespace Boggle
{
    partial class HighScoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScoresForm));
            this.ScoresGrid = new System.Windows.Forms.DataGridView();
            this.RankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScoresGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoresGrid
            // 
            this.ScoresGrid.AllowUserToAddRows = false;
            this.ScoresGrid.AllowUserToDeleteRows = false;
            this.ScoresGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScoresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoresGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RankColumn,
            this.ScoreColumn,
            this.NameColumn,
            this.DateColumn});
            this.ScoresGrid.Location = new System.Drawing.Point(16, 20);
            this.ScoresGrid.MultiSelect = false;
            this.ScoresGrid.Name = "ScoresGrid";
            this.ScoresGrid.ReadOnly = true;
            this.ScoresGrid.RowHeadersVisible = false;
            this.ScoresGrid.Size = new System.Drawing.Size(488, 412);
            this.ScoresGrid.TabIndex = 1;
            // 
            // RankColumn
            // 
            this.RankColumn.FillWeight = 38.20899F;
            this.RankColumn.HeaderText = "Rank";
            this.RankColumn.Name = "RankColumn";
            this.RankColumn.ReadOnly = true;
            // 
            // ScoreColumn
            // 
            this.ScoreColumn.FillWeight = 40.6821F;
            this.ScoreColumn.HeaderText = "Score";
            this.ScoreColumn.Name = "ScoreColumn";
            this.ScoreColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.FillWeight = 80.99546F;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            this.DateColumn.FillWeight = 80F;
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // HighScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 449);
            this.Controls.Add(this.ScoresGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighScoresForm";
            this.Text = "High Scores";
            this.Load += new System.EventHandler(this.HighScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoresGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ScoresGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    }
}