using System;
using System.Diagnostics;
using System.Formats.Asn1;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Styling;
using MINE.UI;

namespace MINE;


// This Class is intended to be inherited
public class Cell :Panel
{

    protected bool _revealed;
    protected bool _flaged;
    
    
    protected Button _button;
    protected Image _image;
    public Cell()
    {
        // Set up innitial value for Cell
        _revealed = false;
        _flaged = false;
        
        _button = new Button();
        _button.Height = 40;
        _button.Width = 40;
        _button.Opacity = 0.5;
        
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
            (sender as Button).IsEnabled = false;
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
            return;
        }
    }

    protected virtual void ExtentFuctionLeftClick()
    {
        
    }
    protected virtual void ExtentFuctionRightClick() { }
    
    

}