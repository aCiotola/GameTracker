using Newtonsoft.Json;

namespace GameTracker.Classes
{
    /// <summary>
    /// Class responsible for representing a specific genre.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    class Genre
    {
        [JsonProperty]
        private int id;
        public string name;
        public string slug;
        public int games_count;
        public string image_background;

        /// <summary>
        /// Constructor for setting up a Genre.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="games_count"></param>
        /// <param name="image_background"></param>
        public Genre(int id, string name, string slug, int games_count, string image_background)
        {
            this.id = id;
            this.name = name;
            this.slug = slug;
            this.games_count = games_count;
            this.image_background = image_background;
        }

        /// <summary>
        /// Override of ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return id + " " + name + " " + slug + " " + games_count + " " + image_background;
        }
    }
}
