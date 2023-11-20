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
    public Button MenuButton = new Button  {
        Background = Brushes.WhiteSmoke,
        Foreground = Brushes.Black,
        FontWeight = FontWeight.Bold,
        FontSize = 20d,
        Content = "Return to Menu",
        HorizontalAlignment = HorizontalAlignment.Center,
    };
    
    public LoseSrceen()
    {
        InitializeComponent();
        MenuPanel.Children.Add(MenuButton);
        MenuButton.Click += (sender, args) =>
        {
            
            (this.Parent.Parent.Parent.Parent as MainWindow).Reset();
        };


    }
}