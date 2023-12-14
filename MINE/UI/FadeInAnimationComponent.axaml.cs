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

public partial class FadeInAnimationComponent: Panel
{
    public FadeInAnimationComponent()
    {
        InitializeComponent();

        Kill();

    }

    private async Task Kill()
    {
        await Task.Delay(2000);
        (this.Parent as Panel).Children.Remove(this);
    }
}