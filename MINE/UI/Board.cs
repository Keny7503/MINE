using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace MINE;

public class Board: Panel
{
    private int column;
    private int row;
    public Cell[,] btnBoard;



    public void SetTable(int[,] table)
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
                btnBoard[i,j] = new Cell();
                rowStackPanel.Children.Add(btnBoard[i,j]);
                var bt = new TextBlock();

             
            }
        }
        this.Children.Add(colunmStackPanel);
    }



    public Board(int column, int row)
    {
        
        this.column = column;
        this.row = row;
        btnBoard= new Cell[column,row];

        

    }
    
}