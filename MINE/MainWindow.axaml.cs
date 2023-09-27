using Avalonia.Controls;
using MINE.Data;
namespace MINE;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        /*
        int[,] placeHolderTable =
        {
            {0,2,3},
            {4,5,6},
            {8,0,9}
        };
        BoardData boardData = new BoardData();
        */
        // boardData.getBoard();

        
        //var board = new Board();

        BoardData Board = new BoardData(15, 20);
        CellData[,] BoardData = Board.CreateBoard();
        int[,] UIBoard = Board.UIBoard(BoardData);


        var board = new Board();
        RootPanel.Children.Add(board);
        board.SetTable(UIBoard);
        //Test comment

    }
}