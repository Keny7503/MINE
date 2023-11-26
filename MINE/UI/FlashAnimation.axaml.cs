using System;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Transformation;
using Avalonia.Styling;

namespace MINE.UI;

public partial class FlashAnimation: Panel
{
    public FlashAnimation()
    {
        InitializeComponent();
        // this.Children.Add(Button1);
        Kill();

    }

    private async Task Kill()
    {
        await Task.Delay(700);
        (this.Parent as Panel).Children.Remove(this);
    }
}