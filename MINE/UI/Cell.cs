using System;
using System.Diagnostics;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Styling;

namespace MINE.UI;

public delegate void RevealEventHandler();

// This Class is intended to be inherited
public class Cell :Panel
{
    private static int _size = 50;
    public bool Revealed;
    public bool Flagged;
    public event RevealEventHandler OnReveal;
    
    public readonly Button Button;
    protected readonly Image Image;
    public Cell()
    {
        // Set up initial value for Cell
        Revealed = false;
        Flagged = false;
        
        // Set up UI elements
        Button = new Button
        {
            Width = _size,
            Height = _size,
            Styles =
            {
                new Style(x => x.OfType<Button>())
                {
                    Setters =
                    {
                        new Setter(
                            Button.OpacityProperty,
                            0.0)
                    },
                },
                new Style(x => x.OfType<Button>().Class(":pointerover"))
                {
                    Setters =
                    {
                        new Setter(
                            Button.OpacityProperty,
                            1.0)
                    },
                },
            },
            Transitions = new Transitions
            {
                new DoubleTransition()
                {
                    Property = Button.OpacityProperty,
                    Duration = TimeSpan.FromSeconds(0.1),
                }
            }
        };
        
        Image = new Image
        {
            Height = _size,
            Width = _size,
            Stretch = Stretch.Fill,
            Source = new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/cell.png")))
        };
        
        
        this.Children.Add(Image);
        this.Children.Add(Button);
        
        // add method to events to handel left mouse click and mouse right click 
        Button.Click += OnLeftClick;
        Button.PointerPressed += OnRightClick;
        
    }
    // This function is for parent control to set this size proportion to screen size
    public static int Size
    {
        set { _size = value; }
    }

    // This function to help indicate a safe starting cell
    public void Highlight()
    {
        Button.Opacity = 1;
        Button.Content = "Start";
        Button.FontWeight = FontWeight.Bold;
        Button.Foreground = Brushes.Black;
        Button.Background = Brushes.Chartreuse;
    }

    private void OnLeftClick(object? sender, RoutedEventArgs e)    
    {
        LeftClick();
    }
    
    // this function is for simulate a click without clicking. Is needed for automatic empty cell clicking
    public void LeftClick()
    {
        Debug.WriteLine("Left");
        if (!Flagged)
        {
            this.IsEnabled = false;
            Revealed = true;
            ExtentFunctionLeftClick();

            OnReveal();

        }
    }
    
    private void OnRightClick(object? sender, PointerPressedEventArgs e)
    {
        Debug.WriteLine("Right");
        if (!Revealed)
        {
            Flagged = !Flagged;
            if (Flagged)
            {
                Image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/flag.png")));
            }
            else
            {
                Image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/cell.png")));

            }
        }
        ExtentFunctionRightClick();

    }
    
    // these two function for extensible feature for different cell class
    protected virtual void ExtentFunctionLeftClick() { }
    protected virtual void ExtentFunctionRightClick() { }
    
    

}