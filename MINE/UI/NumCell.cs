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
        Image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/cell.png")));
        
    }

    protected override void ExtentFunctionLeftClick()
    {
        if (_number>0&&_number < 9) // Safty gate
        {
            Image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/"+_number+".png")));

        }

    }

    

    


}