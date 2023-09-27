using Avalonia.Controls;
using MINE.Data;
<<<<<<< HEAD
=======
using MINE.UI;

>>>>>>> 7433012aeac66169e3c5e0804ffdb9d12a626b5b
namespace MINE;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

<<<<<<< HEAD
        /*
=======
        const int row = 15;
        const int column = 20;
        
>>>>>>> 7433012aeac66169e3c5e0804ffdb9d12a626b5b
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

        
<<<<<<< HEAD
        //var board = new Board();
=======
        var board = new Board(column,row);
>>>>>>> 7433012aeac66169e3c5e0804ffdb9d12a626b5b

        BoardData Board = new BoardData(15, 20);
        CellData[,] BoardData = Board.CreateBoard();
        int[,] UIBoard = Board.UIBoard(BoardData);


        var board = new Board();
        RootPanel.Children.Add(board);
        board.SetTable(UIBoard);
        //Test comment

    }
}