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

public partial class FadeInAnimation: Panel
{
    public FadeInAnimation()
    {
        InitializeComponent();

        Kill();

    }

    private async Task Kill()
    {
        await Task.Delay(5000);
        (this.Parent as Panel).Children.Remove(this);
    }
}