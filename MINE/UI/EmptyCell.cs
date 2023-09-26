using System;
using System.Diagnostics;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace MINE.UI;

public class EmptyCell: NumCell
{
    public EmptyCell() : base(0)
    {
        
    }
    protected override void ExtentFuctionLeftClick()
    {
        _image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/0.png")));
        
    }



}