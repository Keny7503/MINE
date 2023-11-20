using System;
using System.Data.Common;
using System.Diagnostics;
using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Styling;
using MINE.Data;

namespace MINE.UI
{
	public class Menu: Panel
	{
		//private readonly Button playButton;
		private readonly ListBox _difficultyList = new ListBox
		{
			Items = { "Easy","Medium","HUMANLY IMPOSIBLE" }
		};

		private readonly Image _backgroundImage = new Image
		{
			Source =  new Bitmap(AssetLoader.Open(new Uri("avares://MINE/Assets/menu.png"))),
		};

		private readonly TextBlock _title = new TextBlock
		{
			Text = "M.I.N.E.\nmine is not easy",
			TextAlignment = TextAlignment.Center,
			FontSize = 50.0d,
			FontWeight = FontWeight.Bold,
			HorizontalAlignment = HorizontalAlignment.Center,
			VerticalAlignment = VerticalAlignment.Top,
			Margin = new Thickness(200), 
		};
		
		int[,] UIBoard;
        int Row_th;
        int Col_th;
        string difficulty;
        public Menu()
		{

            _difficultyList.SelectionChanged += DifficultyList_SelectionChanged;
            StackPanel stackPanel = new StackPanel
            {
	            Orientation = Orientation.Vertical,
	            VerticalAlignment = VerticalAlignment.Center,
	            HorizontalAlignment = HorizontalAlignment.Center,
            };
            stackPanel.Children.Add(_difficultyList);
            this.Children.Add(_backgroundImage);
            this.Children.Add(_title);

            this.Children.Add(stackPanel);
		}

        private void DifficultyList_SelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            difficulty = _difficultyList.SelectedItem.ToString();

            BoardData Board = new BoardData(15, 20, difficulty);

            //set the difficulty, place the mine, numbering the cell
            CellData[,] BoardData = Board.CreateBoard();

            //create the UIboard
            UIBoard = Board.UIBoard(BoardData, ref Row_th, ref Col_th);

            this.Children.Clear();
            var board = new Board(15, 20);
            this.Children.Add(board);
            board.SetTable(UIBoard, Row_th, Col_th);
        }
        


    }
}

