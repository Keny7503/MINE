using Avalonia.Controls;
using MINE.Data;

namespace MINE;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        int[,] placeHolderTable =
        {
            {0,2,3},
            {4,5,6},
            {8,0,9}
        };
        BoardData boardData = new BoardData();
        // boardData.getBoard();

        
        var board = new Board();

        RootPanel.Children.Add(board);
        board.SetTable(placeHolderTable);
        //Test comment

    }
}