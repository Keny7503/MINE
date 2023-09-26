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
            {1,2,3},
            {4,5,6},
            {8,0,9}
        };
        BoardData boardData = new BoardData();
        // boardData.getBoard();

        
        var board = new Board(placeHolderTable.GetLength(0), placeHolderTable.GetLength(1));
        RootPanel.Children.Add(board);
        board.SetTable(placeHolderTable);
        //Test comment

    }
}