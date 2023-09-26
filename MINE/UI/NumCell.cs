using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace MINE.UI;

public class NumCell: Cell
{
    private int _number;
    

    public NumCell(int number)
    {
        _number = number;
        new Cell();
        _image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/cell.png")));
        
    }

    protected override void ExtentFuctionLeftClick()
    {
        _image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/"+_number+".png")));

    }


}