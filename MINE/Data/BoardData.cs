using System;
namespace MINE.Data
{
	public class BoardData
	{
		protected int width;
		protected int height;
		public BoardData()
		{
			height = 0;
			width = 0;
        }
		public BoardData(int Row, int Col)
		{
			height = Row;
			width = Col;
        }
        //the createboard() function is too place the mine and numberring the cell
		public CellData[,] CreateBoard()
		{
            CellData[,] Board= new CellData[height,width];
            //fix "object reference not set to an instance of an object" error
            for (int i = 0; i < height; i++)
            {
                for (int y = 0; y < width; y++)
                {
					Board[i, y] = new CellData();
                }
            }

            //Board[1, 0].IsMine = true;
            //Board[1, 0].SurroundingMine = 9;
            //Board[3, 0].IsMine = true;
            //Board[3, 0].SurroundingMine = 9;
            //Board[4, 0].IsMine = true;
            //Board[4, 0].SurroundingMine = 9;
            //Board[7, 0].IsMine = true;
            //Board[7, 0].SurroundingMine = 9;
            //Board[9, 0].IsMine = true;
            //Board[9, 0].SurroundingMine = 9;

            //place mine
            for (int i = 0; i < height; i++)
            {
                for (int y = 0; y < width; y++)
                {
                    Random temp = new Random();
                    int temp2 = temp.Next(1, 100);
                    if (temp2 > 0 && temp2 <= 15)
                    {
                        Board[i, y].IsMine = true;
                        Board[i, y].SurroundingMine = 9;
                    }
                    else
                    {
                        Board[i, y].IsMine = false;
                        Board[i, y].SurroundingMine = 0;
                    }
                }
            }


            //numberring cell
            for (int i = 0; i < height; i++)
            {
                for (int y = 0; y < width; y++)
                {
                    if (Board[i, y].IsMine == true && Board[i, y].SurroundingMine>=9)
                    {
                        int[] surroundingCell = Board[i, y].surroundingCell(i, y);
                        
                        if (i == 0)                   //numberring row 1
                        {
                            if ( y == 0 )             //numberring corner cell no.1
                            {
                                Board[0, 1].SurroundingMine++;
                                Board[1, 0].SurroundingMine++;
                                Board[1, 1].SurroundingMine++;
                            }
                            else if ( y == width - 1) //numberring corner cell no.2
                            {
                                if(y<10)
                                {
                                    Board[surroundingCell[3] / 10 - 1, surroundingCell[3] % 10].SurroundingMine++;
                                    Board[surroundingCell[5] / 10 - 1, surroundingCell[5] % 10].SurroundingMine++;
                                    Board[surroundingCell[6] / 10 - 1, surroundingCell[6] % 10].SurroundingMine++;
                                }
                                else
                                {
                                    Board[surroundingCell[3] / 100 - 1, surroundingCell[3] % 100].SurroundingMine++;
                                    Board[surroundingCell[5] / 100 - 1, surroundingCell[5] % 100].SurroundingMine++;
                                    Board[surroundingCell[6] / 100 - 1, surroundingCell[6] % 100].SurroundingMine++;
                                }
                            }
                            else                      //numberring other cell on row 1
                            {
                                if (y < 10)
                                {
                                    Board[surroundingCell[3] / 10 - 1, surroundingCell[3] % 10].SurroundingMine++;
                                    Board[surroundingCell[4] / 10 - 1, surroundingCell[4] % 10].SurroundingMine++;
                                    Board[surroundingCell[5] / 10 - 1, surroundingCell[5] % 10].SurroundingMine++;
                                    Board[surroundingCell[6] / 10 - 1, surroundingCell[6] % 10].SurroundingMine++;
                                    Board[surroundingCell[7] / 10 - 1, surroundingCell[7] % 10].SurroundingMine++;
                                }
                                else
                                {
                                    Board[surroundingCell[3] / 100 - 1, surroundingCell[3] % 100].SurroundingMine++;
                                    Board[surroundingCell[4] / 100 - 1, surroundingCell[4] % 100].SurroundingMine++;
                                    Board[surroundingCell[5] / 100 - 1, surroundingCell[5] % 100].SurroundingMine++;
                                    Board[surroundingCell[6] / 100 - 1, surroundingCell[6] % 100].SurroundingMine++;
                                    Board[surroundingCell[7] / 100 - 1, surroundingCell[7] % 100].SurroundingMine++;
                                }
                            }
                        }
                        else if ( i == height - 1 )   //numberring last row
                        {
                            if (y == 0)               //numberring corner cell no.3
                            {
                                if (y < 10)
                                {
                                    Board[surroundingCell[1] / 10 - 1, surroundingCell[1] % 10].SurroundingMine++;
                                    Board[surroundingCell[2] / 10 - 1, surroundingCell[2] % 10].SurroundingMine++;
                                    Board[surroundingCell[4] / 10 - 1, surroundingCell[4] % 10].SurroundingMine++;
                                }
                                else
                                {
                                    Board[surroundingCell[1] / 100 - 1, surroundingCell[1] % 100].SurroundingMine++;
                                    Board[surroundingCell[2] / 100 - 1, surroundingCell[2] % 100].SurroundingMine++;
                                    Board[surroundingCell[4] / 100 - 1, surroundingCell[4] % 100].SurroundingMine++;
                                }
                            }
                            else if (y == width - 1)  //numberring corner cell no.4
                            {
                                if (y < 10)
                                {
                                    Board[surroundingCell[0] / 10 - 1, surroundingCell[0] % 10].SurroundingMine++;
                                    Board[surroundingCell[1] / 10 - 1, surroundingCell[1] % 10].SurroundingMine++;
                                    Board[surroundingCell[3] / 10 - 1, surroundingCell[3] % 10].SurroundingMine++;
                                }
                                else
                                {
                                    Board[surroundingCell[0] / 100 - 1, surroundingCell[0] % 100].SurroundingMine++;
                                    Board[surroundingCell[1] / 100 - 1, surroundingCell[1] % 100].SurroundingMine++;
                                    Board[surroundingCell[3] / 100 - 1, surroundingCell[3] % 100].SurroundingMine++;
                                }
                            }
                            else                      //numberring other cell on lart row
                            {
                                if (y < 10)
                                {
                                    Board[surroundingCell[0] / 10 - 1, surroundingCell[0] % 10].SurroundingMine++;
                                    Board[surroundingCell[1] / 10 - 1, surroundingCell[1] % 10].SurroundingMine++;
                                    Board[surroundingCell[2] / 10 - 1, surroundingCell[2] % 10].SurroundingMine++;
                                    Board[surroundingCell[3] / 10 - 1, surroundingCell[3] % 10].SurroundingMine++;
                                    Board[surroundingCell[4] / 10 - 1, surroundingCell[4] % 10].SurroundingMine++;
                                }
                                else
                                {
                                    Board[surroundingCell[0] / 100 - 1, surroundingCell[0] % 100].SurroundingMine++;
                                    Board[surroundingCell[1] / 100 - 1, surroundingCell[1] % 100].SurroundingMine++;
                                    Board[surroundingCell[2] / 100 - 1, surroundingCell[2] % 100].SurroundingMine++;
                                    Board[surroundingCell[3] / 100 - 1, surroundingCell[3] % 100].SurroundingMine++;
                                    Board[surroundingCell[4] / 100 - 1, surroundingCell[4] % 100].SurroundingMine++;
                                }
                            }
                        }
                        else if (y == 0 && i!=0 && i!=height-1)              //numberring collume 1
                        {
                            if (y < 10)
                            {
                                Board[surroundingCell[1] / 10 - 1, surroundingCell[1] % 10].SurroundingMine++;
                                Board[surroundingCell[2] / 10 - 1, surroundingCell[2] % 10].SurroundingMine++;
                                Board[surroundingCell[4] / 10 - 1, surroundingCell[4] % 10].SurroundingMine++;
                                Board[surroundingCell[6] / 10 - 1, surroundingCell[6] % 10].SurroundingMine++;
                                Board[surroundingCell[7] / 10 - 1, surroundingCell[7] % 10].SurroundingMine++;
                            }
                            else
                            {
                                Board[surroundingCell[1] / 100 - 1, surroundingCell[1] % 100].SurroundingMine++;
                                Board[surroundingCell[2] / 100 - 1, surroundingCell[2] % 100].SurroundingMine++;
                                Board[surroundingCell[4] / 100 - 1, surroundingCell[4] % 100].SurroundingMine++;
                                Board[surroundingCell[6] / 100 - 1, surroundingCell[6] % 100].SurroundingMine++;
                                Board[surroundingCell[7] / 100 - 1, surroundingCell[7] % 100].SurroundingMine++;
                            }
                        }
                        else if (y == width - 1 && i != 0 && i != height - 1)      //numberring last collume
                        {
                            if (y < 10)
                            {
                                Board[surroundingCell[0] / 10 - 1, surroundingCell[0] % 10].SurroundingMine++;
                                Board[surroundingCell[1] / 10 - 1, surroundingCell[1] % 10].SurroundingMine++;
                                Board[surroundingCell[3] / 10 - 1, surroundingCell[3] % 10].SurroundingMine++;
                                Board[surroundingCell[5] / 10 - 1, surroundingCell[5] % 10].SurroundingMine++;
                                Board[surroundingCell[6] / 10 - 1, surroundingCell[6] % 10].SurroundingMine++;
                            }
                            else
                            {
                                Board[surroundingCell[0] / 100 - 1, surroundingCell[0] % 100].SurroundingMine++;
                                Board[surroundingCell[1] / 100 - 1, surroundingCell[1] % 100].SurroundingMine++;
                                Board[surroundingCell[3] / 100 - 1, surroundingCell[3] % 100].SurroundingMine++;
                                Board[surroundingCell[5] / 100 - 1, surroundingCell[5] % 100].SurroundingMine++;
                                Board[surroundingCell[6] / 100 - 1, surroundingCell[6] % 100].SurroundingMine++;
                            }
                        }
                        else                          //numberring orther cell
                        {
                            if (y < 10)
                            {
                                for(int z = 0; z < 8; z++)
                                {
                                    Board[surroundingCell[z] / 10 - 1, surroundingCell[z] % 10].SurroundingMine++;
                                }
                            }
                            else
                            {
                                for (int z = 0; z < 8; z++)
                                {
                                    Board[surroundingCell[z] / 100 - 1, surroundingCell[z] % 100].SurroundingMine++;
                                }
                            }
                          
                        }
                    }
                }
            }
            return Board;
		}
        //the UIboard() function is for the UI
		public int[,] UIBoard(CellData[,] Board)
		{
			int[,] UIBoard = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int y = 0; y < width; y++)
                {
                    UIBoard[i, y] = Board[i, y].SurroundingMine;
                }
            }
            return UIBoard;
		}
	}
}

