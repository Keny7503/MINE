using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;

namespace MINE;

public class Board: Panel
{
    private int column;
    private int row;
    public Button[,] btnBoard;



    public void SetTable()
    {
        var colunmStackPanel = new StackPanel();
        colunmStackPanel.Orientation = Orientation.Vertical;
        for (int i = 0; i < column; i++)
        {
            var rowStackPanel = new StackPanel();
            rowStackPanel.Orientation = Orientation.Horizontal;
            colunmStackPanel.Children.Add(rowStackPanel);
            for (int j = 0; j < row; j++)
            {
                btnBoard[i,j] = new Button();
                btnBoard[i, j].Content = "0";
                
                rowStackPanel.Children.Add(btnBoard[i,j]);
                


            }
        }
        this.Children.Add(colunmStackPanel);
    }

 


    public Board(int column, int row)
    {
        this.column = column;
        this.row = row;
        btnBoard= new Button[column,row];
        // btnBoard[2, 2] = new Button();
    }
    
}