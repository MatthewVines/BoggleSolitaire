using System;
using System.Windows.Forms;

namespace Boggle
{
    public partial class AddHighScoreForm : Form
    {
        private int _scoreValue;

        public AddHighScoreForm(int scoreValue)
        {
            _scoreValue = scoreValue;

            InitializeComponent();
        }

        private void SaveScoreButton_Click(object sender, EventArgs e)
        {
            Score score = new Score(){Name = NameTextBox.Text, Value = _scoreValue, Date = DateTime.Now};

            HighScores highScores = new HighScores();
            highScores.InsertScore(score);
            highScores.PersistScores();

            this.Close();
        }

        private void AddHighScoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HighScoresForm highScoresForm = new HighScoresForm();
            highScoresForm.Show();
        }
    }
}
