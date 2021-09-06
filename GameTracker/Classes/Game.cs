using Newtonsoft.Json;

namespace GameTracker.Classes
{
    /// <summary>
    /// Class responsible for representing a specific game.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    class Game
    {
        [JsonProperty]
        private int id { set; get; }
        public string name { set; get; }
        public string description { set; get; }
        public int? metacritic { set; get; }
        public string released { set; get; }
        public string background_image { set; get; }
        public string background_image_additional { set; get; }
        public string website { set; get; }
        public string[] alternative_names { set; get; }
        public GamePlatform[] platforms { set; get; }
        public Genre[] genres { set; get; }

        /// <summary>
        /// Constructor for setting up a Game.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="metacritic"></param>
        /// <param name="released"></param>
        /// <param name="background_image"></param>
        /// <param name="background_image_additional"></param>
        /// <param name="website"></param>
        /// <param name="alternative_names"></param>
        /// <param name="platforms"></param>
        /// <param name="genres"></param>
        public Game(int id, string name, string description, int? metacritic, string released, string background_image, 
            string background_image_additional, string website, string[] alternative_names, GamePlatform[] platforms, Genre[] genres)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.metacritic = metacritic;
            this.released = released;
            this.background_image = background_image;
            this.background_image_additional = background_image_additional;
            this.website = website;
            this.alternative_names = alternative_names;
            this.platforms = platforms;
            this.genres = genres;
        }

        /// <summary>
        /// Override of ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return id + " " + name + " " + description + " \n" + metacritic + " " + released + " " + background_image + " \n" + website + " "
                + alternative_names + " \n" + platforms[0] + " \n" + genres[0];
        }
    }
}
