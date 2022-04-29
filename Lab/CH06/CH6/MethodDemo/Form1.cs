namespace MethodDemo
{
    public partial class Form1 : Form
    {
        string[] movieTitles = 
        {
           "Aliens",
           "The Delta Force",
           "Event Horizon",
           "Wonder Woman",
           "Ghostbusters"
        };
        string[] actorNames = new string[5]
        {
            "Sigorney Weaver",
            "Chuck Norris",
            "Sam Neill",
            "Gal Gadot",
            "Dan Aykroyd"
        };
        string[] directorNames = new string[5]
        {
            "Ridley Scott",
            "Menahem Golan",
            "Paul W.S. Anderson",
            "Patty Jenkins",
            "Ivan Reitman"
        };
        string[] studioNames = new string[5]
        {
            "20th Century Fox",
            "Cannon Films",
            "Paramount Pictures",
            "Warner Bros.",
            "Columbia Pictures"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void movieSearchBtn_Click(object sender, EventArgs e)
        {
            string movieName = titleBox.Text;
            int moviePosition = FindMovie(movieName);
            MovieInfo(moviePosition);
        }

        private void actorSearchBtn_Click(object sender, EventArgs e)
        {
            string performers = actorBox.Text;
            int actorPosition = FindPerformer(performers);
            MovieInfo(actorPosition);
        }

        private void directorSearchBtn_Click(object sender, EventArgs e)
        {
            string directorName = directorBox.Text;
            int directorPosition = FindDirector(directorName);
            MovieInfo(directorPosition);
        }

        private void studioSearchBtn_Click(object sender, EventArgs e)
        {
            string studioName = studioBox.Text;
            int studioPosition = FindStudio(studioName);
            MovieInfo(studioPosition);
        }
        private int FindMovie(string movie)
        {
            int moviePosition = -1;

            for (int i = 0; i < movieTitles.Length; i++)
            {
                if (movieTitles[i].ToLower().Contains(movie.ToLower()))
                {
                    moviePosition = i;
                }
               
            }
            return moviePosition;
        }
        private int FindPerformer(string actor)
        {
            int actorPosition = -1;

            for (int i = 0; i < actorNames.Length; i++)
            {
                if (actorNames[i].ToLower().Contains(actor.ToLower()))
                {
                    actorPosition = i;
                }
               
            }
            return actorPosition;
        }
        private int FindDirector(string director)
        {
            int directorPosition = -1;

            for (int i = 0;i < directorNames.Length; i++)
            {
                if (directorNames[i].ToLower().Contains(director.ToLower()))
                {
                    directorPosition = i;
                }
               
            }
            return directorPosition;
        }
        private int FindStudio(string studio)
        {
            int studioPosition = -1;

            for (int i = 0; i < studioNames.Length; i++)
            {
                if (studioNames[i].ToLower().Contains(studio.ToLower()))
                {
                    studioPosition = i;
                }
               
            }
            return studioPosition;
        }
        private void MovieInfo(int position)
        {
            string errorMsg = "Movie not found";

            if (position < 0)
            {
                lblMovieOut.Text = errorMsg;
                lblStarringOut.Text = errorMsg;
                lblDirectorOut.Text = errorMsg;
                lblStudioOut.Text = errorMsg;
            }
            else 
            {
                lblMovieOut.Text = movieTitles[position];
                lblStarringOut.Text = actorNames[position];
                lblDirectorOut.Text = directorNames[position];
                lblStudioOut.Text = studioNames[position];
            }
            
        }
    }
}