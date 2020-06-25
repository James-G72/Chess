using System;
namespace Board
{
    public class BoardHold
    {
        // The board will be an 8x8 square
        public int size { get; set; }

        // We have created CellHold to store information about the grid
        // Here we call for a 2D CellHold array
        public CellHold[,] grid { get; set; }

        // Board constructor
        public BoardBuild (int s)
        {
            size = s;
            grid = new CellHold(size, size);

            // We want to affect all of the values in grid once and initialise a CellHold
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j] = new CellHold(i, j);
                }
            }
        }
    }
}
