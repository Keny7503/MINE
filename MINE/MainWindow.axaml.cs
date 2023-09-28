using Avalonia.Controls;
using MINE.Data;

using MINE.UI;

namespace MINE;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();


        /*

        const int row = 15;
        const int column = 20;
        

        int[,] placeHolderTable =
        {
            {0,0,1,9,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,1,9,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,1,9,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        };
        BoardData boardData = new BoardData();
        */
        // boardData.getBoard();

        

        //var board = new Board();

        BoardData Board = new BoardData(15, 20);
        CellData[,] BoardData = Board.CreateBoard();
        int[,] UIBoard = Board.UIBoard(BoardData);


        var board = new Board(15,20);
        RootPanel.Children.Add(board);
        board.SetTable(UIBoard);
        //Test comment

    }
}