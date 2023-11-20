using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using MINE.Data;
using MINE.UI;

namespace MINE;

public partial class MainWindow : Window
{
    private Button exitBtn = new Button
    {
        Margin = Thickness.Parse("0,10,10,0"),
        Content = "X",
        HorizontalAlignment = HorizontalAlignment.Right,
        VerticalAlignment = VerticalAlignment.Top,
        Background = Brushes.PaleVioletRed,


    };
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
        RootPanel.Children.Add(exitBtn);
        exitBtn.Click += (sender, args) => { Close(); };

        // Uncomment the below if you want to see the hold board
        // board.RevealAll();


    }

    public void Reset()
    {
        RootPanel.Children.Clear();
        UI.Menu menuGame = new UI.Menu();
        RootPanel.Children.Add(menuGame);
        RootPanel.Children.Add(exitBtn);

    }
}