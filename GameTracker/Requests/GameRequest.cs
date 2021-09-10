using GameTracker.Classes;
using GameTracker.Utilities;
using Newtonsoft.Json;
using RestSharp;

namespace GameTracker.Requests
{
    /// <summary>
    /// Class responsible for sending requests for certain game information.
    /// </summary>
    class GameRequest
    {
        private RestSharpUtil util = new RestSharpUtil();
        private string APIKEY;

        /// <summary>
        /// No parameter constructor used to get the API key.
        /// </summary>
        public GameRequest()
        {
            APIKEY = util.APIKEY;
        }

        /// <summary>
        /// Method responsible for getting detailed information on a game.
        /// </summary>
        /// <returns></returns>
        public Game GetGameInfo(string game_name)
        {
            IRestResponse response = util.CreateRequest("https://rawg-video-games-database.p.rapidapi.com/games/" + game_name + "?key=" + APIKEY);
            Game game = JsonConvert.DeserializeObject<Game>(response.Content);
            return game;
        }

        /// <summary>
        /// Method responsible for getting a list of all games in a series.
        /// </summary>
        /// <param name="game_name"></param>
        /// <returns></returns>
        public GameSeries GetGameSeries(string game_name)
        {
            IRestResponse response = util.CreateRequest("https://rawg-video-games-database.p.rapidapi.com/games/" + game_name + "/game-series?key=" + APIKEY);
            GameSeries games = JsonConvert.DeserializeObject<GameSeries>(response.Content);
            return games;
        }
    }
}
