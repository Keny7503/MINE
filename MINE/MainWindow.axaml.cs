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
        // boardData.getBoard();

        
        var board = new Board(column,row);

        RootPanel.Children.Add(board);
        board.SetTable(placeHolderTable);
        //Test comment

    }
}