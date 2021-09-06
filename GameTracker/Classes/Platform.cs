using Newtonsoft.Json;

namespace GameTracker.Classes
{
    /// <summary>
    /// Class responsible for representing a specific platform.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    class Platform
    {
        [JsonProperty]
        private int id { set; get; }
        public string name { set; get; }
        public int games_count { set; get; }
        public string image_background { set; get; }
        public string? image { set; get; }
        public int? year_start { set; get; }
        public int? year_end { set; get; }

        /// <summary>
        /// Constructor for setting up a platform.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="games_count"></param>
        /// <param name="image"></param>
        /// <param name="year_start"></param>
        /// <param name="year_end"></param>
        public Platform(int id, string name, int games_count, string image_background, string? image, int? year_start, int? year_end)
        {
            this.id = id;
            this.name = name;   
            this.games_count = games_count;
            this.image_background = image_background;
            this.image = image;
            this.year_start = year_start;
            this.year_end = year_end;
        }

        /// <summary>
        /// Override of ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            return id + " " + name + " " + games_count + " " + image_background + " " + image + " " + year_start + " " + year_end;
        }           
    }
}
