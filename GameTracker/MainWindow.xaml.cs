using GameTracker.Classes;
using GameTracker.Models;
using GameTracker.Requests;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace GameTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
            DisplaySeriesList();

            //PlatformRequest pReq = new PlatformRequest();
            //GenreRequest gReq = new GenreRequest();
        }

        /// <summary>
        /// Method responsible for getting a list of games the user currently has in their collection.
        /// </summary>
        public void DisplaySeriesList()
        {
            GameRequest gameRequest = new GameRequest();
            List<GameModel> gameModels = new List<GameModel>();

            // Add current game to model.
            Game game = gameRequest.GetGameInfo("kingdom-hearts-iii");
            gameModels.Add(GetGameDetails(game));

            // Add rest of the games to the model.
            GameSeries games = gameRequest.GetGameSeries("kingdom-hearts-iii");
            for (int i = 0; i < games.results.Length; i++)
            {
                GameModel model = GetGameDetails(games.results[i]);                
                gameModels.Add(model);
            }

            gameGrid.ItemsSource = gameModels;
        }

        /// <summary>
        /// Clean way to split details of a game into a model used for the datagrid.
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        private GameModel GetGameDetails(Game game)
        {
            // Get the game image.
            BitmapImage gameImage = new BitmapImage(new Uri(game.background_image, UriKind.Absolute));

            // Get list of platforms the game is on.
            string platforms = "";
            for (int j = 0; j < game.platforms.Length; j++)
            {
                if (j != 0)
                    platforms += ", ";
                platforms += game.platforms[j].platform.name;
            }

            // Create the model.
            GameModel model = new GameModel(gameImage, game.name, game.released, platforms, game.metacritic + "");
            return model;
        }
    }
}
