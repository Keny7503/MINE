using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace MINE.UI;

public class MineCell: Cell
{
    public MineCell()
    {
        new Cell();
        _image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/mine.png")));

    }
}