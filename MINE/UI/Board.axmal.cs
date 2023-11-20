using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.VisualTree;

namespace MINE.UI;


public delegate void WinEventHandler();

public partial class Board: Panel
{
    private int _column;
    private int _row;
    private readonly Cell[,] _cellBoard ;
    private int _revealedCell;
    private int _mineCount;
    private int _mineLeft;
    private const string _mineLeftString = "Mines left: ";

    public readonly TextBlock MineLeftText = new TextBlock
    {
        HorizontalAlignment = HorizontalAlignment.Center,
        FontSize = 40,
        Foreground = Brushes.Red,
        Margin = Thickness.Parse("0,0,0,40")
    };

    private readonly Panel _headerBar = new Panel();
    private readonly Image _backgroundImage = new Image
    {
        Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/BombBG.png"))),
    };
   
    public event WinEventHandler OnWin;
    

    // separate setting up creating UI from the constructor for more freedom when creating and using this class
    public void SetTable(int[,] table, int hlRow, int hlColumn)
    {
        
        
        _revealedCell = 0;
        _column = table.GetLength(0);
        _row = table.GetLength(1);
        Cell.Size = ((int)this.GetTransformedBounds()!.Value.Clip.Bottom)/20; 
        this.Children.Add(_backgroundImage);
        BackgroundAnimation brA = new BackgroundAnimation();
        this.Children.Add(brA);
        
        // create StackPanels on another StackPanel to make a grid of Cell
        var colunmStackPanel = new StackPanel
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
        };
        
        
        
        // Test button
        _headerBar.Children.Add(MineLeftText);
        colunmStackPanel.Children.Add(_headerBar);


        colunmStackPanel.Orientation = Orientation.Vertical;
        for (int i = 0; i < _column; i++)
        {
            var rowStackPanel = new StackPanel();
            rowStackPanel.Orientation = Orientation.Horizontal;
            colunmStackPanel.Children.Add(rowStackPanel);
            for (int j = 0; j < _row; j++)
            {
                // the table parameter use for mapping value from 0 to 9 to Cell on screen with 9 representing mines
                if (table[i, j] > 0 && table[i, j] < 9)
                {
                    _cellBoard[i,j] = new NumCell(table[i,j]);
                    
                }
                else if (table[i, j] == 0)
                {
                    _cellBoard[i, j] = new EmptyCell();
                    var localJ = j;
                    var localI = i;
                    _cellBoard[i, j].Button.Click += (sender, e) =>
                    {
                        Debug.WriteLine("Empty click");
                        ClickSurroundCell(localI,localJ);

                    };
                }
                else
                {
                    _cellBoard[i,j] = new MineCell();
                    ((_cellBoard[i, j] as MineCell)!).OnLose += () =>
                    {
                        MineLeftText.Text = "KABOOOOOOOOOOOOOOOOOOOOOOOOM"; 
                        DisableAll();
                        this.Children.Clear();
                        this.Children.Add(new LoseSrceen());
                    };
                    _mineCount++;
                }
                _cellBoard[i, j].OnReveal += OnCellReveal;

                rowStackPanel.Children.Add(_cellBoard[i,j]);
                
            }
        }
        
        // set flag trigger
        for (int i = 0; i < _column; i++)
        {
            for (int j = 0; j < _row; j++)
            {
                _cellBoard[i, j].PointerPressed += OnCellFlag;
            }
        }
        
        //Winning condtion
        OnWin += () =>
        {
            MineLeftText.Text = "WINNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN";
            DisableAll();
            this.Children.Clear();
            this.Children.Add(new WinSrceen());
            
        };

        
        this.Children.Add(colunmStackPanel);
        HighlightCell(hlRow,hlColumn);
        _mineLeft = _mineCount;
        MineLeftText.Text = _mineLeftString+ _mineLeft.ToString();

        
        


    }

    private void OnCellFlag(object? sender, PointerPressedEventArgs e)
    {
        if (((sender as Cell)!).Flagged)
        {
            _mineLeft--;
            
            
        }
        else
        {
            _mineLeft++;
        }
        MineLeftText.Text = _mineLeftString+ _mineLeft.ToString();
    }
    

    private void OnCellReveal()
    {
        
        _revealedCell++;
        if (_revealedCell >= (_column * _row - _mineCount))
        {
            Debug.WriteLine("Win");

            OnWin();
        }
    }
    


    private void ClickSurroundCell(int column, int row)
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
        
            }
        }
        
    }
    
    

    public void ClickAt(int column, int row)
    {

        // Prevent clicking if the cell is mine or flagged or revealed
        if ((_cellBoard[column, row].GetType() == typeof(MineCell))||
            (_cellBoard[column, row].Flagged)||
            _cellBoard[column, row].Revealed)
        {
            return;
        }
        (_cellBoard[column,row] as NumCell)?.LeftClick();

        
        if (_cellBoard[column, row].GetType() == typeof(EmptyCell))
        {
            ClickSurroundCell(column,row);
            
        }


    }

    public void HighlightCell(int row, int column)
    {
        _cellBoard[row,column].Highlight();
    }

    public void RevealAll()
    {
        for (int i = 0; i < _column; i++)
        {
            for (int j = 0; j < _row; j++)
            {
                ClickAt(i,j);
            }
        }
    }
    public void DisableAll()
    {
        for (int i = 0; i < _column; i++)
        {
            for (int j = 0; j < _row; j++)
            {
                _cellBoard[i, j].Button.IsEnabled = false;
            }
        }
    }



    // Contructor use for pre-determine the size of the array
    public Board(int row, int column)
    {
        InitializeComponent();
        _cellBoard= new Cell[row,column];


    }

}