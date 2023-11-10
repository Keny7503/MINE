using Avalonia.Controls;
using MINE.Data;

using MINE.UI;

namespace MINE;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();


        
        
        const int row = 15;
        const int column = 20;
        
        
        //int[,] placeHolderTable =
        //{
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,1,0,0,1,0,0,1,0,1,1,1,0,1,0,0,0,0,1,0},
        //    {0,1,0,0,1,0,0,1,0,1,0,1,0,1,1,0,0,0,1,0},
        //    {0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,0,1,0},
        //    {0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,0,1,0,1,0},
        //    {0,1,1,0,0,0,1,1,0,1,0,1,0,1,0,0,0,1,1,0},
        //    {0,1,1,0,0,0,1,1,0,1,0,1,0,1,0,0,0,0,1,0},
        //    {0,1,0,0,0,0,0,1,0,1,1,1,0,1,0,0,0,0,1,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        //};
        

        BoardData Board = new BoardData(row, column);

        //is this to save the number of mines
        int numberOfMine = -1;

        //set the difficulty, place the mine, numbering the cell
        CellData[,] BoardData = Board.CreateBoard("medium",ref numberOfMine);

        //is this to save the empty cell
        int row_th = 0;
        int col_th = 0;

        //create the UIboard
        int[,] UIBoard = Board.UIBoard(BoardData, ref row_th, ref col_th);


        var board = new Board(row,column);
        RootPanel.Children.Add(board);
        board.SetTable(UIBoard, row_th,col_th);

        // Uncomment the below if you want to see the hold board
        // board.RevealAll();


    }
}