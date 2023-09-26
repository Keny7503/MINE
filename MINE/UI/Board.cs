using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using MINE.UI;

namespace MINE;

public class Board: Panel
{
    private int column;
    private int row;
    public Cell[,] btnBoard ;


    // seperate setting up creating UI from the contructor for more freedom when creating and using this class
    public void SetTable(int[,] table)
    {
        column = table.GetLength(0);
        row = table.GetLength(1);
        
        
        // create StackPanels on another StackPanel to make a grid of Cell
        var colunmStackPanel = new StackPanel();
        colunmStackPanel.Orientation = Orientation.Vertical;
        for (int i = 0; i < column; i++)
        {
            var rowStackPanel = new StackPanel();
            rowStackPanel.Orientation = Orientation.Horizontal;
            colunmStackPanel.Children.Add(rowStackPanel);
            for (int j = 0; j < row; j++)
            {
                // the table parameter use for mapping value from 0 to 9 to Cell on screen with 9 representing mines
                if (table[i, j] > 0 && table[i, j] < 9)
                {
                    btnBoard[i,j] = new NumCell(table[i,j]);
                }
                else if (table[i, j] == 0)
                {
                    btnBoard[i, j] = new EmptyCell();
                }
                else
                {
                    btnBoard[i,j] = new MineCell();
                }
                

                rowStackPanel.Children.Add(btnBoard[i,j]);
                
            }
        }
        this.Children.Add(colunmStackPanel);


        // var testBtn = new Button();
        // colunmStackPanel.Children.Add(testBtn);
        // testBtn.Click += onClick;
        //
        // void onClick(object? sender, RoutedEventArgs e)
        // {
        //     ClickAt(0,0);
        //     Debug.WriteLine("testBtn");
        // }
    }




    public void ClickAt(NumCell cell)
    {
        cell.ExternalClick();
    }

    public Board()
    {
        btnBoard= new Cell[10,10];
    }

}