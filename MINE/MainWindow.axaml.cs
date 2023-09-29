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
        CellData[,] BoardData = Board.CreateBoard();
        int[,] UIBoard = Board.UIBoard(BoardData);


        var board = new Board(row,column);
        RootPanel.Children.Add(board);
        board.SetTable(UIBoard);
        
        
        // Uncomment the below if you want to see the hold board
        board.RevealAll();


    }
}