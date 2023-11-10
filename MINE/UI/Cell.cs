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
    private const int size= 60;



    public bool _revealed;
    public bool _flaged;
    
    // This action is for the user of the class to get the
    public event RevealEventHandler OnReveal;


    public readonly Button _button;
    protected readonly Image _image;
    public Cell()
    {
        // Set up innitial value for Cell
        _revealed = false;
        _flaged = false;
        
        
        // Set up UI elements
        _button = new Button
        {
            Width = size,
            Height = size,
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
        
        
        _image = new Image
        {
            Height = size,
            Width = size,
            Stretch = Stretch.Fill,
            Source = new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/cell.png")))
        };
        
        
        this.Children.Add(_image);
        this.Children.Add(_button);
        
        
        // add method to events to handel left mouse click and mouse right click 
        _button.Click += onLeftClick;
        _button.PointerPressed += onRightClick;
        
    }

    public void Highlight()
    {
        _button.Opacity = 0.5;
        _button.Content = "Start";
    }

    private void onLeftClick(object? sender, RoutedEventArgs e)     // sender this the object
    {
        LeftClick();
    }
    
    
    public void LeftClick()
    {
        Debug.WriteLine("Left");
        if (!_flaged)
        {
            this.IsEnabled = false;
            _revealed = true;
            ExtentFuctionLeftClick();

            if (OnReveal != null)
            {
                OnReveal();
            }
            
        }
    }
    
    private void onRightClick(object? sender, PointerPressedEventArgs e)
    {
        Debug.WriteLine("Right");
        if (!_revealed)
        {
            _flaged = !_flaged;
            if (_flaged)
            {
                _image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/flag.png")));
            }
            else
            {
                _image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/cell.png")));

            }
        }
        ExtentFuctionRightClick();

    }
   
    protected virtual void ExtentFuctionLeftClick() { }
    protected virtual void ExtentFuctionRightClick() { }
    
    

}