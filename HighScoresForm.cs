using System;
using System.Windows.Forms;

namespace Boggle
{
    public partial class HighScoresForm : Form
    {
        public HighScoresForm()
        {
            InitializeComponent();
        }

        private void HighScoresForm_Load(object sender, EventArgs e)
        {
            HighScores highScores = new HighScores();

            for(int i = 0; i < highScores.Scores.Count; i++)
            {
                ScoresGrid.Rows.Add((i + 1).ToString(), highScores.Scores[i].Value, highScores.Scores[i].Name, highScores.Scores[i].Date);
            }
        }
    }
}
