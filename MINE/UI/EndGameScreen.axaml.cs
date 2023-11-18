using System;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Media.Transformation;
using Avalonia.Platform;
using Avalonia.Styling;

namespace MINE.UI;

public partial class EndGameSrceen: Panel
{
    private Image _image = new Image();
    public EndGameSrceen()
    {
        InitializeComponent();
        _image = new Image
        {
            Stretch = Stretch.Fill,
            Source = new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/explosion.png")))
        };

    }
}