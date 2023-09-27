using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace MINE.UI;

public class EmptyCell: NumCell
{
    // public int row_cord;
    // public int column_cord;


        

    public EmptyCell() : base(0)
    {
        // row_cord = row;
        // column_cord = col;


        // (nextCell as NumCell)?.ExternalClick();

    }


    // private void ApplySurroundCell()
    // {
    //     for (int i = column_cord-1; i < column_cord+1; i++)
    //     {
    //         for (int j = row_cord-1; j < row_cord+1; j++)
    //         {
    //             if (i<0 ||i>2||j<0||j>2)
    //             {
    //                 continue;
    //             }
    //               
    //         }
    //     }
    // }

    protected override void ExtentFuctionLeftClick()
    {
        _image.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/0.png")));
        
        
    }
    


}
