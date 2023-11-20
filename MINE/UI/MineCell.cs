using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace MINE.UI;

public delegate void LoseEventHandler();

public class MineCell: Cell
{
    public event LoseEventHandler OnLose;

    protected override void ExtentFunctionLeftClick()
    {
        Image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/mine.png")));
        OnLose();
    }
}