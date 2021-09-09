using GameTracker.Classes;
using GameTracker.Models;
using GameTracker.Requests;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows;

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
            DisplayGameList();

            //PlatformRequest pReq = new PlatformRequest();
            //GenreRequest gReq = new GenreRequest();
        }

        /// <summary>
        /// Method responsible for getting a list of games the user currently has in their collection.
        /// </summary>
        public void DisplayGameList()
        {
            GameRequest gameRequest = new GameRequest();

            List<GameModel> gameModels = new List<GameModel>();
            List<string> gameList = new List<string>();
            gameList.Add("kingdom-hearts-iii");
            gameList.Add("super-mario-galaxy");

            for (int i = 0; i < gameList.Count; i++)
            {
                // Get the game information.
                Game game = gameRequest.GetGameInfo(gameList[i]);

                // Get the image from the site.
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(game.background_image);
                MemoryStream ms = new MemoryStream(bytes);
                Image gameImage = Image.FromStream(ms);

                // Get list of platforms the game is on.
                string platforms = "";
                for (int j = 0; j < game.platforms.Length; j++)
                {
                    if (j != 0)
                        platforms += ", ";
                    platforms += game.platforms[j].platform.name;
                }

                // Create model after the game and add to list.
                GameModel model = new GameModel(gameImage, game.name, game.released, platforms, game.metacritic + "");
                gameModels.Add(model);
            }

            gameGrid.ItemsSource = gameModels;
        }
    }
}
