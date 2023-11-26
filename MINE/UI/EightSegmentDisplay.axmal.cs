using System;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace MINE.UI;

public partial class EightSegmentDisplay : Panel
{

    public EightSegmentDisplay()
    {
        InitializeComponent();
    }

    public void SetNumber(int number)
    {
        numberTextBlock.Text = number.ToString();
    }
    

}