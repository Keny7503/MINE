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
using MINE.Data;

namespace MINE.UI
{
	public class Menu: Panel
	{
		//private readonly Button playButton;
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
        string difficulty;
        public Menu()
		{
   //         playButton = new Button();
			//playButton.Content = "Click me";
   //         playButton.Width = 90;
   //         playButton.Height = 40;
   //         playButton.Background = Brushes.Black;
   //         playButton.Click += PlayButton_Click;
            difficultyList.SelectionChanged += DifficultyList_SelectionChanged;
            StackPanel stackPanel = new StackPanel
            {
	            Orientation = Orientation.Vertical,
	            VerticalAlignment = VerticalAlignment.Center,
	            HorizontalAlignment = HorizontalAlignment.Center,
            };
            //stackPanel.Children.Add(playButton);
            stackPanel.Children.Add(difficultyList);
            this.Children.Add(backgroundImage);

            this.Children.Add(stackPanel);
		}

        private void DifficultyList_SelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            difficulty = difficultyList.SelectedItem.ToString();

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
        
        public void Reset()
        {
	        this.GetType().GetConstructor(Type.EmptyTypes).Invoke(this, new object[] { });
        }

   //     private void PlayButton_Click(object? sender, RoutedEventArgs e)
   //     {
			//this.Children.Clear();
   //         var board = new Board(15, 20);
   //         this.Children.Add(board);
   //         board.SetTable(UIBoard, Row_th, Col_th);
   //     }
    }
}

