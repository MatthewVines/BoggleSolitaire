using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Boggle
{
    public partial class ScoreForm : Form
    {
        private readonly Board _board;
        private readonly List<string> _wordlist;
        private int _totalScore = 0;

        public ScoreForm(Board board, List<string> wordList)
        {
            InitializeComponent();

            _board = board;
            _wordlist = wordList;
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            List<string> usedWords = new List<string>();

            foreach (string word in _wordlist)
            {
                string result;
                bool isGoodWord = false;

                if (word.Length < 3)
                {
                    result = "Too Short";
                }
                else if (usedWords.Contains(word))
                {
                    result = "Already Used";
                }
                else if (WordDictionary.IsWordInDictionary(word))
                {
                    if (_board.IsWordValid(word))
                    {
                        isGoodWord = true;
                        result = "Good Word";
                    }
                    else
                    {
                        result = "Not on the Board";
                    }
                }
                else
                {
                    result = "Not In Dictionary";
                }

                int score = 0;
                if (isGoodWord)
                {
                    score = ScoreWord(word);
                }

                usedWords.Add(word);

                WordsGrid.Rows.Add(word, result, score);
            }

            _totalScore = 0;
            foreach (DataGridViewRow row in WordsGrid.Rows)
            {
                _totalScore += (int) row.Cells[2].Value;
                if ((int)row.Cells[2].Value == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
            ScoreLabel.Text = _totalScore.ToString();

            HighScores highScores = new HighScores();
            if (_totalScore > 0 && highScores.IsScoreAHighScore(_totalScore))
            {
                this.Closing += new System.ComponentModel.CancelEventHandler(ScoreForm_Closing);
            }
        }

        private void ScoreForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AddHighScoreForm addhighScoreForm = new AddHighScoreForm(_totalScore);
            addhighScoreForm.ShowDialog(this);
        }

        private int ScoreWord(string word)
        {
            int score = 0;
            switch (word.Length)
            {
                case 0:
                case 1:
                case 2:
                    score = 0;
                    break;
                case 3:
                case 4:
                    score = 1;
                    break;
                case 5:
                    score = 2;
                    break;
                case 6:
                    score = 3;
                    break;
                case 7:
                    score = 5;
                    break;
                default:
                    score = 11;
                    break;
            }
            return score;
        }

        private void HighScoresButton_Click(object sender, EventArgs e)
        {
            HighScoresForm highScoresForm = new HighScoresForm();
            highScoresForm.ShowDialog(this);
        }
    }
}
