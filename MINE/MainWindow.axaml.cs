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
    // Since the game is fullscreen, a clode button is needed
    private readonly Button _exitBtn = new Button
    {
        Margin = Thickness.Parse("0,10,10,0"),
        Content = "X",
        HorizontalAlignment = HorizontalAlignment.Right,
        VerticalAlignment = VerticalAlignment.Top,
        Background = Brushes.PaleVioletRed,
        Foreground = Brushes.White,

    };
    public MainWindow()
    {
        InitializeComponent();
        UI.Menu menuGame = new UI.Menu();
        RootPanel.Children.Add(menuGame);
        RootPanel.Children.Add(_exitBtn);
        _exitBtn.Click += (sender, args) => { Close(); };

        // Uncomment the below if you want to see the hold board
        // board.RevealAll();


    }
    // This function for navigation back to menu when a game is ended
    public void Reset()
    {
        RootPanel.Children.Clear();
        UI.Menu menuGame = new UI.Menu();
        RootPanel.Children.Add(menuGame);
        RootPanel.Children.Add(_exitBtn);

    }
}