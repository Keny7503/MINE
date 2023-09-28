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


// This Class is intended to be inherited
public class Cell :Panel
{

    public bool _revealed;
    public bool _flaged;


    public readonly Button _button;
    protected readonly Image _image;
    public Cell()
    {
        // Set up innitial value for Cell
        _revealed = false;
        _flaged = false;

        _button = new Button
        {
            Width = 40,
            Height = 40,
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
        
        
        // _button.Height = 40;
        // _button.Width = 40;
        // _button.Opacity = 0.0;
        
        _image = new Image();
        _image.Height = 40;
        _image.Width = 40;
        _image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/cell.png")));
        
        this.Children.Add(_image);
        this.Children.Add(_button);
        
        
        // add method to events to handel left mouse click and mouse right click 
        _button.PointerPressed += onRightClick;
        _button.Click += onLeftClick;

    }

    protected virtual void onLeftClick(object? sender, RoutedEventArgs e)     // sender this the object
    {
        
        if (!_flaged)
        {
            ((sender as Button)!).IsEnabled = false;
            Debug.WriteLine("L");

            _revealed = true;
            ExtentFuctionLeftClick();
            
            
        }

        
    }

    private void onRightClick(object? sender, PointerPressedEventArgs e)
    {
        if (e.Pointer.IsPrimary)
        {
            Debug.WriteLine("R");

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
    }

    protected virtual void ExtentFuctionLeftClick()
    {
        
    }
    protected virtual void ExtentFuctionRightClick() { }
    
    

}