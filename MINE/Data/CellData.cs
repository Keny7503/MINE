using System;
using System.Collections.Generic;

namespace MINE.Data
{
	public class CellData
	{
		protected int RowIndex;			//unused
		protected int ColIndex;         //unused
        protected bool isMine;			//determine the cell has mine or not
		protected int surroundingMine;  //determine the number of mine surrounding the cell
        public CellData()
		{
			isMine = false;
			surroundingMine = 0;
        }
		public bool IsMine
		{
			get { return isMine; }
			set { isMine = value; }
		}
		public int SurroundingMine
		{
			get { return surroundingMine; }
			set { surroundingMine = value; }
		}
		public void getIndex(int Row, int Col)
		{
			RowIndex = Row;
			ColIndex = Col;
        }

        //surroundingCell() function is too store the index of the Surrounding Cell
        public int[] surroundingCell(int Row, int Col)
		{
			int[] cell = new int[8];
			if(Col<10)
			{
				cell[0] = Row * 10 + (Col - 1);
				cell[1] = Row * 10 + Col;
				cell[2] = Row * 10 + (Col + 1);
				cell[3] = (Row + 1) * 10 + (Col - 1);
				cell[4] = (Row + 1) * 10 + (Col + 1);
				cell[5] = (Row + 2) * 10 + (Col - 1);
				cell[6] = (Row + 2) * 10 + Col;
				cell[7] = (Row + 2) * 10 + (Col + 1);
			}
			else
			{
                cell[0] = Row * 100 + (Col - 1);
                cell[1] = Row * 100 + Col;
                cell[2] = Row * 100 + (Col + 1);
                cell[3] = (Row + 1) * 100 + (Col - 1);
                cell[4] = (Row + 1) * 100 + (Col + 1);
                cell[5] = (Row + 2) * 100 + (Col - 1);
                cell[6] = (Row + 2) * 100 + Col;
                cell[7] = (Row + 2) * 100 + (Col + 1);
            }

            return cell;
		}

    }
}

