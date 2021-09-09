using GameTracker.Classes;
using GameTracker.Responses;
using GameTracker.Utilities;
using Newtonsoft.Json;
using RestSharp;
using System.Windows;

namespace GameTracker.Requests
{
    /// <summary>
    /// Class responsible for sending requests for certain genre information.
    /// </summary>
    class GenreRequest
    {
        private RestSharpUtil util = new RestSharpUtil();
        private string APIKEY;

        /// <summary>
        /// No parameter constructor used to get the API key.
        /// </summary>
        public GenreRequest()
        {
            APIKEY = util.APIKEY;
            MessageBox.Show(GetAllGenres()[1].ToString());
        }

        /// <summary>
        /// Method responsible for getting a detailed list of all genres.
        /// </summary>
        /// <returns></returns>
        public Genre[] GetAllGenres()
        {
            IRestResponse response = util.CreateRequest("https://rawg-video-games-database.p.rapidapi.com/genres?key=" + APIKEY);
            JsonGenre json = JsonConvert.DeserializeObject<JsonGenre>(response.Content);
            return json.GetResults();
        }
    }
}
