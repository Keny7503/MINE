using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Styling;
namespace MINE.UI;

public partial class LoseSrceen: Panel
{
    public Button PlayAgainButton = new Button
    {
        Content = "Play Again",

        HorizontalAlignment = HorizontalAlignment.Left,
        
    };
    public Button MenuButton = new Button  {
        Content = "Menu",
        HorizontalAlignment = HorizontalAlignment.Right,
    };
    
    public LoseSrceen()
    {
        InitializeComponent();
        MenuPanel.Children.Add(PlayAgainButton);
        MenuPanel.Children.Add(MenuButton);
        PlayAgainButton.Click += (sender, args) =>
        {
            (Parent as Panel).Children.Remove(this);
        };


    }
}