using Avalonia.Controls;

namespace MINE;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        int[,] placeHolderTable = {{1,2,3},{4,5,6},{7,8,9}};

        
        var board = new Board(placeHolderTable.GetLength(0), placeHolderTable.GetLength(1));
        RootPanel.Children.Add(board);
        board.SetTable(placeHolderTable);
        //Test comment

    }
}