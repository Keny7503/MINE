using System;
namespace MINE.Data
{
	public class BoardData
	{
		protected int width;
		protected int height;
        string setDifficulty;
        int numberOfMine;

        public BoardData()
		{
			height = 0;
			width = 0;
            setDifficulty = "easy";
        }
		public BoardData(int Row, int Col, string setDifficulty)
		{
			height = Row;
			width = Col;
            this.setDifficulty = setDifficulty;
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

            //set difficulty
            if(setDifficulty=="Easy")
            {
                numberOfMine = 30;
            }
            else if(setDifficulty == "Medium")
            {
                numberOfMine = 45;
            }
            else
            {
                numberOfMine = 60;
            }

            //place mine
            while(true)
            {
                if (numberOfMine == 0)
                {
                    break;
                }
                for (int i = 0; i < height; i++)
                {
                    if (numberOfMine == 0)
                    {
                        break;
                    }
                    for (int y = 0; y < width; y++)
                    {
                        if (numberOfMine == 0)
                        {
                            break;
                        }
                        Random temp = new Random();
                        int temp2 = temp.Next(1, 100);
                        if (temp2 > 0 && temp2 <= 13 && Board[i, y].IsMine != true)
                        {
                            Board[i, y].IsMine = true;
                            Board[i, y].SurroundingMine = 9;
                            numberOfMine--;
                        }
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

                        if (i == 0 && y == 0)//numberring corner cell no.1
                        {
                            Board[0, 1].SurroundingMine++;
                            Board[1, 0].SurroundingMine++;
                            Board[1, 1].SurroundingMine++;
                        }
                        else if(i == 0 && y == width - 1)//numberring corner cell no.2
                        {
                            if (y < 9)
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
                        else if(i == height - 1 && y == 0)//numberring corner cell no.3
                        {
                            if (y < 9)
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
                        else if(i == height - 1 && y == width - 1)//numberring corner cell no.4
                        {
                            if (y < 9)
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
                        else if(i == 0 && y != 0 && y != width - 1)//numberring other cell on row 1
                        {
                            if (y < 9)
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
                        else if(i == height - 1 && y != 0 && y != width - 1)//numberring other cell on lart row
                        {
                            if (y < 9)
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
                        else if(y == 0 && i != height - 1 && i != 0)//numberring other cell on collumn 1
                        {
                            if (y < 9)
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
                        else if(y == width - 1 && i != height - 1 && i != 0)//numberring other cell on last collumn
                        {
                            if (y < 9)
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
                        else if(i != height - 1 && i != 0 && y != 0 && y != width - 1)//numberring orther cell
                        {
                            if (y < 9)
                            {
                                for (int z = 0; z < 8; z++)
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
		public int[,] UIBoard(CellData[,] Board,ref int row_th,ref int col_th)
		{
            Random temp = new Random();
            int[,] UIBoard = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int y = 0; y < width; y++)
                {
                    UIBoard[i, y] = Board[i, y].SurroundingMine;
                    int temp2 = temp.Next(1, 2);
                    if (Board[i, y].IsMine == false && temp2==1 && row_th==0 && Board[i,y].SurroundingMine==0)
                    {
                        row_th = i;
                        col_th = y;
                    }
                }
            }
            return UIBoard;
		}
	}
}

