using System;

namespace Boggle
{
    public class Cube
    {
        public string Faces { get; set; }
        public char ActiveFace { get; set; }

        public Cube NorthNeighbor { get; set; }
        public Cube SouthNeighbor { get; set; }
        public Cube EastNeighbor { get; set; }
        public Cube WestNeighbor { get; set; }
        public Cube NorthWestNeighbor { get; set; }
        public Cube NorthEastNeighbor { get; set; }
        public Cube SouthWestNeighbor { get; set; }
        public Cube SouthEastNeighbor { get; set; }

        public Cube(string faces)
        {
            Faces = faces;
        }

        public void Roll()
        {
            Random random = new Random();
            ActiveFace = Faces[random.Next(0, Faces.Length - 1)];
        }

        public override string ToString()
        {
            if (ActiveFace == 'Q')
            {
                return "Qu";
            }
            else
            {
                return ActiveFace.ToString();
            }
        } 
    }
}
