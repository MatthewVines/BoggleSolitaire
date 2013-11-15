using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boggle
{
    public class ScoreValueComparer : IComparer<Score>
    {
        public int Compare(Score x, Score y)
        {
            if (x.Value < y.Value)
            {
                return -1;
            }

            if (x.Value > y.Value)
            {
                return 1;
            }

            if (x.Value == y.Value)
            {
                if (x.Date > y.Date)
                {
                    return 1;
                }

                if (x.Date < y.Date)
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
