using System.Drawing;
using System.Windows.Media.Imaging;

namespace GameTracker.Models
{
    /// <summary>
    /// Class responsible for representing a specific game for use in the datagrid.
    /// </summary>
    class GameModel
    {
        public BitmapImage image {  get; set; }
        public string name {  get; set; }
        public string released { get; set; }
        public string platforms {  get; set; }
        public string metacritic {  get; set; }

        /// <summary>
        /// Constructor for setting up the game data.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="name"></param>
        /// <param name="released"></param>
        /// <param name="platforms"></param>
        /// <param name="metacritic"></param>
        public GameModel(BitmapImage image, string name, string released, string platforms, string metacritic)
        {
            this.image = image;
            this.name = name;
            this.released = released;
            this.platforms = platforms;
            this.metacritic = metacritic;
        }
    }
}
