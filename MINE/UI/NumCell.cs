using System;
using System.Diagnostics;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace MINE.UI;

public class NumCell: Cell
{
    private int _number;
    

    public NumCell(int number)
    {
        _number = number;
        _image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/cell.png")));
        
    }

    protected override void ExtentFuctionLeftClick()
    {
        if (_number>0&&_number < 9) // Safty gate
        {
            _image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/"+_number+".png")));

        }

    }

    protected override void onLeftClick(object? sender, RoutedEventArgs e)
    {
        
        ExternalClick();
    }

    public void ExternalClick()
    {
        if (!_flaged)
        {
            this.IsEnabled = false;
            Debug.WriteLine("L");
            _revealed = true;
            ExtentFuctionLeftClick();
            
            
        }
    }


}