using System;
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
        
        // Start Menu
        
        
        
        
        
        //int[,] placeHolderTable =
        //{
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,1,0,0,1,0,0,1,0,1,1,1,0,1,0,0,0,0,1,0},
        //    {0,1,0,0,1,0,0,1,0,1,0,1,0,1,1,0,0,0,1,0},
        //    {0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,0,1,0},
        //    {0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,0,1,0,1,0},
        //    {0,1,1,0,0,0,1,1,0,1,0,1,0,1,0,0,0,1,1,0},
        //    {0,1,1,0,0,0,1,1,0,1,0,1,0,1,0,0,0,0,1,0},
        //    {0,1,0,0,0,0,0,1,0,1,1,1,0,1,0,0,0,0,1,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        //};
       


        UI.Menu menuGame = new UI.Menu();
        RootPanel.Children.Add(menuGame);
        
        // Uncomment the below if you want to see the hold board
        // board.RevealAll();


    }

    public void Reset()
    {
        RootPanel.Children.Clear();
        UI.Menu menuGame = new UI.Menu();
        RootPanel.Children.Add(menuGame);
    }
}