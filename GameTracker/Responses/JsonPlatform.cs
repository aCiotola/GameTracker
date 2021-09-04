using GameTracker.Classes;

namespace GameTracker.Responses
{
    /// <summary>
    /// Class responsible for representing a Json Platform where the results array contains all platforms.
    /// </summary>
    class JsonPlatform
    {
        private int count;
        private string? next; //? = nullable
        private string? previous;
        private Platform[] results;

        /// <summary>
        /// Constructor for setting up a JsonPlatform.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="next"></param>
        /// <param name="previous"></param>
        /// <param name="results"></param>
        public JsonPlatform(int count, string? next, string? previous, Platform[] results)
        {
            this.count = count;
            this.next = next;
            this.previous = previous;
            this.results = results;
        }

        /// <summary>
        /// Return the array of all platforms.
        /// </summary>
        /// <returns></returns>
        public Platform[] GetResults()
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
