using Newtonsoft.Json;

namespace GameTracker.Classes
{
    /// <summary>
    /// Class responsible for representing the series of a specific game.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    class GameSeries
    {
        [JsonProperty]
        public int count { set; get; }
        public Game[] results { set; get; }

        /// <summary>
        /// Constructor for setting up all series of a game.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="results"></param>
        public GameSeries(int count, Game[] results)
        {
            this.count = count;
            this.results = results;
        }

        /// <summary>
        /// Override of ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return count + " " + results;
        }
    }
}
