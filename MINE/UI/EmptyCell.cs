using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace MINE.UI;

public class EmptyCell: NumCell
{

    public EmptyCell() : base(0)
    {
        
    }
    

    protected override void ExtentFunctionLeftClick()
    {
        Image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/0.png")));
        
        
    }
    


}
