using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Boggle
{
    public class Board
    {
        public readonly int BoardSize;
        private readonly List<string> _cubeFaceSets;

        public List<List<Cube>> Rows { get; set; }

        public Board(string setName)
        {
            _cubeFaceSets = File.ReadAllText(string.Format("Sets/{0}.txt", setName)).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            BoardSize = (int) Math.Sqrt(_cubeFaceSets.Count);

            // Build the Board.
            Rows = new List<List<Cube>>(BoardSize);
            for (int i = 0; i < BoardSize; i++)
            {
                Rows.Add(new List<Cube>(BoardSize));
            }
            
            // Fill the Board.
            Random random = new Random();
            foreach (List<Cube> row in  Rows)
            {
                for (int i = 0; i < BoardSize; i++)
                {
                    int randomFaceSetIndex = random.Next(0, _cubeFaceSets.Count - 1);
                    row.Add(new Cube(_cubeFaceSets[randomFaceSetIndex]));
                    _cubeFaceSets.RemoveAt(randomFaceSetIndex);
                }
            }

            // Set all the neighbors
            for (int y = 0; y < Rows.Count; y++)
            {
                for (int x = 0; x < Rows[y].Count; x++)
                {
                    if (y > 0 && x > 0)
                    {
                        Rows[y][x].NorthWestNeighbor = Rows[y - 1][x - 1];
                    }

                    if (y > 0)
                    {
                        Rows[y][x].NorthNeighbor = Rows[y - 1][x];
                    }

                    if (y > 0 && x < BoardSize - 1)
                    {
                        Rows[y][x].NorthEastNeighbor = Rows[y - 1][x + 1];
                    }

                    if (x < BoardSize - 1)
                    {
                        Rows[y][x].EastNeighbor = Rows[y][x + 1];
                    }

                    if (y < BoardSize - 1 && x < BoardSize - 1)
                    {
                        Rows[y][x].SouthEastNeighbor = Rows[y + 1][x + 1];
                    }

                    if (y < BoardSize - 1)
                    {
                        Rows[y][x].SouthNeighbor = Rows[y + 1][x];
                    }

                    if (y < BoardSize - 1 && x > 0)
                    {
                        Rows[y][x].SouthWestNeighbor = Rows[y + 1][x - 1];
                    }

                    if (x > 0)
                    {
                        Rows[y][x].WestNeighbor = Rows[y][x - 1];
                    }
                }
            }
        }

        public void Shake()
        {
            Rows.ForEach(row => row.ForEach(cube => cube.Roll()));
        }

        public bool IsWordValid(string word)
        {
            word = word.ToUpper();
            char firstLetter = word.ToCharArray()[0];

            List<Cube> firstLetterCubes = new List<Cube>();

            foreach (List<Cube> row in Rows)
            {
                foreach (Cube cube in row)
                {
                    if (cube.ActiveFace == firstLetter)
                    {
                        firstLetterCubes.Add(cube);
                    }
                }
            }

            foreach (Cube firstLetterCube in firstLetterCubes)
            {
                if (CanTraceWord(word, 0, firstLetterCube, new List<Cube>()))
                {
                    return true;
                }
            }
            // couldn't make it happen
            return false;
        }

        private bool CanTraceWord(string word, int currentCharIndex, Cube startingCube, List<Cube> usedCubes)
        {
            usedCubes.Add(startingCube);

            // we reached the end of the word, yay, it's good.
            if(currentCharIndex >= word.Length - 1)
            {
                return true;
            }

            // find this letter, and set us up to look for the next one.
            List<Cube> nextLetterCubes = null;
            if (word.ToCharArray()[currentCharIndex] == 'Q')
            {
                nextLetterCubes = FindAdjacentCubesThatMatchLetter(word.ToCharArray()[currentCharIndex + 2], startingCube, usedCubes);
            }
            else
            {
                nextLetterCubes = FindAdjacentCubesThatMatchLetter(word.ToCharArray()[currentCharIndex + 1], startingCube, usedCubes);    
            }
            
            if(nextLetterCubes != null)
            {
                foreach (Cube nextCube in nextLetterCubes)
                {
                    if (word.ToCharArray()[currentCharIndex] == 'Q')
                    {
                        if (CanTraceWord(word, currentCharIndex + 2, nextCube, usedCubes))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (CanTraceWord(word, currentCharIndex + 1, nextCube, usedCubes))
                        {
                            return true;
                        }
                    }

                }
            }

            // we can't make the next step, word is invalid.
            return false;
        }

        private List<Cube> FindAdjacentCubesThatMatchLetter(char letter, Cube startingCube, List<Cube> usedCubes)
        {
            List<Cube> foundCubes = new List<Cube>();

            if (startingCube.NorthWestNeighbor != null 
                && !usedCubes.Contains(startingCube.NorthWestNeighbor)
                && startingCube.NorthWestNeighbor.ActiveFace == letter)
            {
                foundCubes.Add(startingCube.NorthWestNeighbor);
            }

            if (startingCube.NorthNeighbor != null
                && !usedCubes.Contains(startingCube.NorthNeighbor)
                && startingCube.NorthNeighbor.ActiveFace == letter)
            {
                foundCubes.Add(startingCube.NorthNeighbor);
            }

            if (startingCube.NorthEastNeighbor != null
                && !usedCubes.Contains(startingCube.NorthEastNeighbor)
                && startingCube.NorthEastNeighbor.ActiveFace == letter)
            {
                foundCubes.Add(startingCube.NorthEastNeighbor);
            }

            if (startingCube.EastNeighbor != null
                && !usedCubes.Contains(startingCube.EastNeighbor)
                && startingCube.EastNeighbor.ActiveFace == letter)
            {
                foundCubes.Add(startingCube.EastNeighbor);
            }

            if (startingCube.SouthEastNeighbor != null
                && !usedCubes.Contains(startingCube.SouthEastNeighbor)
                && startingCube.SouthEastNeighbor.ActiveFace == letter)
            {
                foundCubes.Add(startingCube.SouthEastNeighbor);
            }

            if (startingCube.SouthNeighbor != null
                && !usedCubes.Contains(startingCube.SouthNeighbor)
                && startingCube.SouthNeighbor.ActiveFace == letter)
            {
                foundCubes.Add(startingCube.SouthNeighbor);
            }

            if (startingCube.SouthWestNeighbor != null
                && !usedCubes.Contains(startingCube.SouthWestNeighbor)
                && startingCube.SouthWestNeighbor.ActiveFace == letter)
            {
                foundCubes.Add(startingCube.SouthWestNeighbor);
            }

            if (startingCube.WestNeighbor != null
                && !usedCubes.Contains(startingCube.WestNeighbor)
                && startingCube.WestNeighbor.ActiveFace == letter)
            {
                foundCubes.Add(startingCube.WestNeighbor);
            }

            if(foundCubes.Count == 0)
            {
                return null;
            }

            return foundCubes;
        }
    }
}
