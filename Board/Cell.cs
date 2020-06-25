using System;
namespace Board
{
    public class CellHold
    {
        public int rowNumber { get; set; }
        public int columnNumber { get; set; }
        public bool occupied { get; set; }
        public bool legalMove { get; set; }

        public CellHold(int xValue, int yValue)
        {
            rowNumber = xValue;
            columnNumber = yValue;

        }
    }
}
