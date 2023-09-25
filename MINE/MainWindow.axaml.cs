using Avalonia.Controls;

namespace MINE;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var board = new Board(3, 2);
        RootPanel.Children.Add(board);
        board.SetTable();
        //Test comment
        int[][] placeHolderTable = { 
            new int[]{1,9,2},
            new int[]{1,2,9}, 
            new int[]{0,1,1}};
        
    }
}