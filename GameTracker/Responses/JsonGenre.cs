using GameTracker.Classes;

namespace GameTracker.Responses
{
    /// <summary>
    /// Class responsible for representing a Json Genre where the results array contains all genres.
    /// </summary>
    class JsonGenre
    {
        private int count;
        private string? next;
        private string? previous;
        private Genre[] results;

        /// <summary>
        /// Constructor for setting up a JsonGenre.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="next"></param>
        /// <param name="previous"></param>
        /// <param name="results"></param>
        public JsonGenre(int count, string? next, string? previous, Genre[] results)
        { 
            this.count = count;
            this.next = next;
            this.previous = previous;
            this.results = results;
        }

        /// <summary>
        /// Method responsible for returning all genres.
        /// </summary>
        /// <returns></returns>
        public Genre[] GetResults()
        {
            return results;
        }

        /// <summary>
        /// Override of ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return count + " " + next + " " + previous + " " + results;
        }
    }
}
