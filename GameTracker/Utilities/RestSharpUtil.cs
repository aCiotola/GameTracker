using GameTracker.Classes;
using GameTracker.Responses;
using Newtonsoft.Json;
using RestSharp;
using System.IO;
using System.Windows;

namespace GameTracker.Utilities
{
    class RestSharpUtil
    {
        private string rapidHost = "x-rapidapi-host";
        private string hostSite = "rawg-video-games-database.p.rapidapi.com";
        private string rapidKey = "x-rapidapi-key";
        private string keySite;
        private string APIKEY;

        /// <summary>
        /// No parameter constructor.
        /// </summary>
        public RestSharpUtil() 
        {
            SetAPIKeys();
            Platform[] platforms = GetAllPlatforms();
            MessageBox.Show(platforms[1].ToString());
        }

        /// <summary>
        /// Method rsponsible for receiving the API keys from a file (so it isn't visible online)
        /// </summary>
        private void SetAPIKeys()
        {
            string[] lines = File.ReadAllLines(@"..\..\..\Utilities\keys.txt");
            keySite = lines[0].Trim();
            APIKEY = lines[1].Trim();   
        }

        /// <summary>
        /// Method responsible for creating a request and providing the results depending on the link given.
        /// </summary>
        /// <param name="requestLink"></param>
        /// <returns></returns>
        private IRestResponse CreateRequest(string requestLink) 
        {
            var client = new RestClient(requestLink);
            var request = new RestRequest(Method.GET);
            request.AddHeader(rapidHost, hostSite);
            request.AddHeader(rapidKey, keySite);
            IRestResponse response = client.Execute(request);

            return response;
        }

        /// <summary>
        /// Method responsible for getting a detailed list of all platforms.
        /// </summary>
        /// <returns></returns>
        public Platform[] GetAllPlatforms()
        {
            IRestResponse response = CreateRequest("https://rawg-video-games-database.p.rapidapi.com/platforms?key=" + APIKEY);
            JsonPlatform json = JsonConvert.DeserializeObject<JsonPlatform>(response.Content);
            return json.GetResults();
        }


    }
}
