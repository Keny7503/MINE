using Avalonia.Controls;
using Avalonia.Layout;

namespace MINE.UI;

public class Board: Panel
{
    private int _column;
    private int _row;
    public readonly Cell[,] CellBoard ;


    // seperate setting up creating UI from the contructor for more freedom when creating and using this class
    public void SetTable(int[,] table)
    {
<<<<<<< HEAD
        column = table.GetLength(1);
        row = table.GetLength(0);
=======
        _column = table.GetLength(0);
        _row = table.GetLength(1);
>>>>>>> 7433012aeac66169e3c5e0804ffdb9d12a626b5b
        
        
        // create StackPanels on another StackPanel to make a grid of Cell
        var colunmStackPanel = new StackPanel();
        colunmStackPanel.Orientation = Orientation.Vertical;
<<<<<<< HEAD
        for (int i = 0; i < row; i++)
=======
        for (int i = 0; i < _column; i++)
>>>>>>> 7433012aeac66169e3c5e0804ffdb9d12a626b5b
        {
            var rowStackPanel = new StackPanel();
            rowStackPanel.Orientation = Orientation.Horizontal;
            colunmStackPanel.Children.Add(rowStackPanel);
<<<<<<< HEAD
            for (int j = 0; j < column; j++)
=======
            for (int j = 0; j < _row; j++)
>>>>>>> 7433012aeac66169e3c5e0804ffdb9d12a626b5b
            {
                // the table parameter use for mapping value from 0 to 9 to Cell on screen with 9 representing mines
                if (table[i, j] > 0 && table[i, j] < 9)
                {
                    CellBoard[i,j] = new NumCell(table[i,j]);
                }
                else if (table[i, j] == 0)
                {
                    CellBoard[i, j] = new EmptyCell();
                    var localJ = j;
                    var localI = i;
                    CellBoard[i, j]._button.Click += (sender, e) =>
                    {
                        ClickSurrroundCell(localI,localJ);
        
                    };
                        
                }
                else
                {
                    CellBoard[i,j] = new MineCell();
                }
                

                rowStackPanel.Children.Add(CellBoard[i,j]);
                
            }
        }
        this.Children.Add(colunmStackPanel);
        

        // var testBtn = new Button();
        // colunmStackPanel.Children.Add(testBtn);
        // testBtn.Click += onClick;
        //
        // void onClick(object? sender, RoutedEventArgs e)
        // {
        //     ClickAt(0,1);
        //     Debug.WriteLine("testBtn");
        // }
    }

    // private void onTriggerEmpty(object? sender, RoutedEventArgs e)
    // {
    //     // (sender as EmptyCell)
    //     
    //
    //     // ClickSurrroundCell((sender as EmptyCell).column_cord, (sender as EmptyCell).row_cord);
    //     Debug.WriteLine((sender as EmptyCell).column_cord+""+ (sender as EmptyCell).row_cord);
    // }



    private void ClickSurrroundCell(int column, int row)
    {
        // Debug.WriteLine("click next empty");

        for (int i = column-1; i <= column+1; i++)
        {
            for (int j = row-1; j <= row+1; j++)
            {
                
                
                if (i<0 ||i>this._column-1||j<0||j>this._row-1||(i==column&&j==row))
                {
                    continue;
                }
                ClickAt(i,j);
                // Debug.WriteLine(btnBoard[column,row]._revealed);
                // if (btnBoard[column,row]._revealed)
                // {
                //     ClickAt(i,j);
                //     
                // }
            }
        }
        
    }
    
    

    public void ClickAt(int column, int row)
    {
<<<<<<< HEAD
        btnBoard= new Cell[15,20];
=======
        if (CellBoard[column, row]._revealed )
        {
            return;
            
            // ClickSurrroundCell(column,row);
        }

        // if (btnBoard[column, row].GetType()==typeof(EmptyCell))
        // {
        //     Debug.WriteLine("empty Clicked");
        //     ClickSurrroundCell(column,row);
        // }
        // Debug.WriteLine("auto Clicked"+(btnBoard[column, row].GetType()==typeof(EmptyCell)));

        // In theory, this if statement should not be false but it was add for safety
        if (CellBoard[column, row].GetType() != typeof(MineCell))
        {
            (CellBoard[column,row] as NumCell)?.ExternalClick();
            
        }

        if (CellBoard[column, row].GetType() == typeof(EmptyCell))
        {
            ClickSurrroundCell(column,row);
            
        }


    }
    // Contructor use for pre-determine the size of the array
    public Board(int column,int row)
    {
        CellBoard= new Cell[row,column];
>>>>>>> 7433012aeac66169e3c5e0804ffdb9d12a626b5b
    }

}