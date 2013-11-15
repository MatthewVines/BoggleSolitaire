using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Boggle
{
    public class HighScores
    {
        public List<Score> Scores;

        public HighScores()
        {
            List<string> scoreRecords = File.ReadAllText("HighScores.csv").Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Scores = new List<Score>();
            foreach (string record in scoreRecords)
            {
                List<string> recordFields = new List<string>(record.Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries));

                Score score = new Score(){Name = recordFields[0], Value = int.Parse(recordFields[1]), Date = DateTime.Parse(recordFields[2])};
                Scores.Add(score);
            }

        }

        public bool IsScoreAHighScore(int scoreValue)
        {
            if(Scores.Count < 25)
            {
                return true;
            }

            if (scoreValue >= Scores[Scores.Count - 1].Value)
            {
                return true;
            }
            return false;
        }

        public void InsertScore(Score score)
        {
            Scores.Add(score);
            Scores = new List<Score>(Scores.OrderByDescending(x => x, new ScoreValueComparer()));

            // if there are 26 elements remove the last one
            if (Scores.Count > 25)
            {
                // remember index 25 is the 26th element.
                Scores.RemoveAt(25);
            }
        }

        public void PersistScores()
        {
            using (StreamWriter file = new StreamWriter("HighScores.csv"))
            {
                foreach (Score score in Scores)
                {
                    file.WriteLine(score.Name + "," + score.Value + "," + score.Date);
                }
            }
        }
    }
}
