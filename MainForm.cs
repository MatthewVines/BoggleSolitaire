using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Boggle
{
    public partial class MainForm : Form
    {
        private List<List<Label>> _spaces;
        private Board _board;
        private string _set;
        private int _gameLengthSeconds = 180;

        private int _timerSecondsRemaining;

        private const int LabelSize = 48;
        private const int LabelSpaceSize = 6;

        public MainForm()
        {
            WordDictionary.Initialize();

            InitializeComponent();

            _set = "Modern";
            SetNameLabel.Text = "Modern Boggle";
            InitializeBoard();

            timer1.Enabled = false;
        }

        private void ShakeButton_Click(object sender, EventArgs e)
        {
            SetUpBoard();
            StartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timerSecondsRemaining--;

            SetTimerLabelValue();

            if (_timerSecondsRemaining == 0)
            {
                EndGame();
            }
        }

        private Label CreateLetterLabel(int rowIndex, int colIndex)
        {
            Label l = new Label();
            l.Size = new Size(LabelSize, LabelSize);
            l.Parent = panel1;
            l.BackColor = Color.White;
            l.ForeColor = Color.Black;
            l.Font = new Font(FontFamily.GenericSansSerif, 16f, FontStyle.Bold); 
            l.TextAlign = ContentAlignment.MiddleCenter;

            int xPos = (LabelSize*(colIndex)) + (LabelSpaceSize*colIndex);
            int yPos = (LabelSize*(rowIndex)) + (LabelSpaceSize*rowIndex); 

            l.Location = new Point(xPos, yPos);

            return l;
        }

        private void InitializeBoard()
        {
            _board = new Board(_set);

            int boardPanelSize = (LabelSize * _board.BoardSize) + (LabelSpaceSize * _board.BoardSize - 1);
            panel1.Size = new Size(boardPanelSize, boardPanelSize);

            panel1.Controls.Clear();

            _spaces = new List<List<Label>>();
            for (int rowIndex = 0; rowIndex < _board.Rows.Count; rowIndex++)
            {
                _spaces.Add(new List<Label>());
                for (int colIndex = 0; colIndex < _board.Rows[rowIndex].Count; colIndex++)
                {
                    _spaces[rowIndex].Add(CreateLetterLabel(rowIndex, colIndex));
                }
            }
        }

        private void SetUpBoard()
        {
            _board.Shake();

            for (int rowIndex = 0; rowIndex < _board.Rows.Count; rowIndex++)
            {
                for (int colIndex = 0; colIndex < _board.Rows[rowIndex].Count; colIndex++)
                {
                    _spaces[rowIndex][colIndex].Text = _board.Rows[rowIndex][colIndex].ToString();
                }
            }
        }

        private void SetTimerLabelValue()
        {
            int minutesRemaining = _timerSecondsRemaining / 60;
            int secondsRemaining = _timerSecondsRemaining % 60;
            TimerLabel.Text = string.Format("{0}:{1}", minutesRemaining, secondsRemaining.ToString().PadLeft(2, '0'));
        }

        private void StartGame()
        {
            ShakeButton.Enabled = true;
            WordListTextBox.Enabled = true;
            WordListTextBox.Focus();
            SetTimerLabelValue();
            _timerSecondsRemaining = _gameLengthSeconds;
            timer1.Enabled = true;
            ShakeButton.Visible = false;
            DoneButton.Visible = true;
            DoneButton.Enabled = true;
        }

        private void EndGame()
        {
            DoneButton.Enabled = false;
            ScoreButton.Enabled = true;
            WordListTextBox.Enabled = false;
            timer1.Enabled = false;
        }

        private void ResetGame()
        {
            NewGameButton.Visible = false;
            ScoreButton.Visible = true;
            DoneButton.Visible = false;
            ShakeButton.Visible = true;
            ShakeButton.Enabled = true;
            ScoreButton.Enabled = false;
            WordListTextBox.Text = string.Empty;

            InitializeBoard();

            _spaces.ForEach(row => row.ForEach(space => space.Text = string.Empty));
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm(_board, GetWordList());
            scoreForm.Closed += new EventHandler(scoreForm_Closed);
            scoreForm.ShowDialog(this);
        }

        private void scoreForm_Closed(object sender, EventArgs e)
        {
            NewGameButton.Visible = true;
            ScoreButton.Visible = false;
            NewGameButton.Enabled = true;
        }

        private List<string> GetWordList()
        {
            return new List<string>(WordListTextBox.Text.Split(new string[] {Environment.NewLine, " "}, StringSplitOptions.RemoveEmptyEntries));
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void RotateLeftButton_Click(object sender, EventArgs e)
        {
            RotateLeft();
            WordListTextBox.Focus();
        }

        private void RotateLeft()
        {
            List<List<string>> oldValues = GetCurrentBoardLetterLocations();

            for (int rowIndex = 0; rowIndex < _spaces.Count; rowIndex++)
            {
                for (int colIndex = 0; colIndex < _spaces[rowIndex].Count; colIndex++)
                {
                    int x = (_spaces.Count - 1) - rowIndex;
                    int y = colIndex;

                    _spaces[rowIndex][colIndex].Text = oldValues[y][x];
                }
            }
        }

        private void RotateRightButton_Click(object sender, EventArgs e)
        {
            RotateRight();
            WordListTextBox.Focus();
        }

        private void RotateRight()
        {
            List<List<string>> oldValues = GetCurrentBoardLetterLocations();

            for (int rowIndex = 0; rowIndex < _spaces.Count; rowIndex++)
            {
                for (int colIndex = 0; colIndex < _spaces[rowIndex].Count; colIndex++)
                {
                    int x = rowIndex;
                    int y = (_spaces.Count - 1) - colIndex;

                    _spaces[rowIndex][colIndex].Text = oldValues[y][x];
                }
            }
        }

        private List<List<string>> GetCurrentBoardLetterLocations()
        {
            List<List<string>> oldValues = new List<List<string>>();

            for (int rowIndex = 0; rowIndex < _spaces.Count; rowIndex++)
            {
                oldValues.Add(new List<string>());
                for (int colIndex = 0; colIndex < _spaces[rowIndex].Count; colIndex++)
                {
                    oldValues[rowIndex].Add(_spaces[rowIndex][colIndex].Text);
                }
            }
            return oldValues;
        }

        private void WordListTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                RotateLeft();
            }
            else if (e.KeyCode == Keys.Right)
            {
                RotateRight();
            }
        }

        private void AnySetMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem mi in miSet.DropDownItems)
            {
                if (mi != sender)
                {
                    mi.Checked = false;
                }
                _set = (sender as ToolStripMenuItem).Tag.ToString();
                SetNameLabel.Text = (sender as ToolStripMenuItem).Text;
                InitializeBoard();
            }
        }
    }
}
