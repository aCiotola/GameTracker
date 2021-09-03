using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using RestSharp;
using System.Text.Json;
using RestSharp.Authenticators;

namespace GameTracker.Utilities
{
    class RestSharpUtil
    {
        public RestSharpUtil() {

            var client = new RestClient("https://rawg-video-games-database.p.rapidapi.com/platforms/1?key=db013a96fb7c45cb9b012e6a625d618e");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "rawg-video-games-database.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "7e40c52d95mshfe4b8e96d2705a8p1e477djsnfedab9b3a5a9");
            IRestResponse response = client.Execute(request);

            MessageBox.Show(response.Content);

            //MAKE CLASS WHICH TAKES ALL JSON VALUES
        }


    }
}
