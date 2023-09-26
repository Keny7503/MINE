using System;
namespace MINE.Data
{
	public class CellData
	{
		protected int RowIndex;
		protected int ColIndex;
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
	}
}

