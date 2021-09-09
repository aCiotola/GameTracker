using GameTracker.Classes;
using GameTracker.Responses;
using GameTracker.Utilities;
using Newtonsoft.Json;
using RestSharp;
using System.Windows;

namespace GameTracker.Requests
{
    /// <summary>
    /// Class responsible for sending requests for certain platform information.
    /// </summary>
    class PlatformRequest
    {
        private RestSharpUtil util = new RestSharpUtil();
        private string APIKEY;

        /// <summary>
        /// No parameter constructor used to get API key.
        /// </summary>
        public PlatformRequest()
        {
            APIKEY = util.APIKEY;
            MessageBox.Show(GetAllPlatforms()[1].ToString());
            MessageBox.Show(GetPlatformDetails(8).ToString());
        }

        /// <summary>
        /// Method responsible for getting a detailed list of all platforms.
        /// </summary>
        /// <returns></returns>
        public Platform[] GetAllPlatforms()
        {
            IRestResponse response = util.CreateRequest("https://rawg-video-games-database.p.rapidapi.com/platforms?key=" + APIKEY);
            JsonPlatform json = JsonConvert.DeserializeObject<JsonPlatform>(response.Content);
            return json.GetResults();
        }

        /// <summary>
        /// Method responsible for returning a platforms details based on its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Platform GetPlatformDetails(int id)
        {
            IRestResponse response = util.CreateRequest("https://rawg-video-games-database.p.rapidapi.com/platforms/" + id + "?key=" + APIKEY);
            Platform platform = JsonConvert.DeserializeObject<Platform>(response.Content);
            return platform;
        }
    }
}
