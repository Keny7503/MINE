using System;
using System.Data.Common;
using System.Diagnostics;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Styling;

namespace MINE.UI
{
	public class Menu: Panel
	{
		private readonly Button playButton;
		private ListBox difficultyList = new ListBox
		{
			Items = { "Easy","Medium","HUMANLY IMPOSIBLE" }
		};

		private Image backgroundImage = new Image
		{
			Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/menu.png"))),
		};
		int[,] UIBoard;
        int Row_th;
        int Col_th;
        public Menu(int[,] uiBoard, int row_th, int col_th)
		{
            UIBoard = uiBoard;
            Row_th = row_th;
            Col_th = col_th;
            playButton = new Button();
			playButton.Content = "Click me";
            playButton.Click += PlayButton_Click;
            StackPanel stackPanel = new StackPanel
            {
	            Orientation = Orientation.Vertical,
	            VerticalAlignment = VerticalAlignment.Center,
	            HorizontalAlignment = HorizontalAlignment.Center,
            };
            stackPanel.Children.Add(playButton);
            stackPanel.Children.Add(difficultyList);
            this.Children.Add(backgroundImage);

            this.Children.Add(stackPanel);
		}

        private void PlayButton_Click(object? sender, RoutedEventArgs e)
        {
			this.Children.Clear();
            var board = new Board(15, 20);
            this.Children.Add(board);
            board.SetTable(UIBoard,Row_th, Col_th);
        }
	}
}

