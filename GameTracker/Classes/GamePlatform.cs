using Newtonsoft.Json;

namespace GameTracker.Classes
{
    /// <summary>
    /// Class responsible for representing the platform of a specific game.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    class GamePlatform
    {
        [JsonProperty]
        public Platform platform { set; get; }
        public string released_at { set; get; }

        /// <summary>
        /// Constructor for setting up a Game Platform.
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="released_at"></param>
        public GamePlatform(Platform platform, string released_at)
        { 
            this.platform = platform;
            this.released_at = released_at;
        }

        /// <summary>
        /// Override of ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return platform.ToString() + " " + released_at;
        }
    }
}
