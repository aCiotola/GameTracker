namespace GameTracker.Classes
{
    /// <summary>
    /// Class responsible for representing a specific platform.
    /// </summary>
    class Platform
    {
        private int id;
        private string name;
        private string slug;
        private int games_count;
        private string image_background;
        private string? image;
        private int? year_start;
        private int? year_end;

        /// <summary>
        /// Constructor for setting up a platform.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="games_count"></param>
        /// <param name="image"></param>
        /// <param name="year_start"></param>
        /// <param name="year_end"></param>
        public Platform(int id, string name, string slug, int games_count, string image_background, string? image, int? year_start, int? year_end)
        {
            this.id = id;
            this.name = name;   
            this.slug = slug;
            this.games_count = games_count;
            this.image_background = image_background;
            this.image = image;
            this.year_start = year_start;
            this.year_end = year_end;
        }

        /// <summary>
        /// Method responsible for returning the background image of a platform.
        /// </summary>
        /// <returns></returns>
        public string GetBackgroundImage()
        { 
            return image_background;    
        }

        /// <summary>
        /// Override of ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            return id + " " + name + " " + slug + " " + games_count + " " + image_background + " " + image + " " + year_start + " " + year_end;
        }
           
    }
}
