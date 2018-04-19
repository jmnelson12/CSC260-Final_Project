using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaApp
{
    public partial class MovieApp : Form
    {
        public MovieApp()
        {
            InitializeComponent();

            // Load in movies from db

        }

        #region Navigation
        private void Nav_Buttons(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text.ToLower())
            {
                case "search":
                    getVisisblePanel(pnlSearch, pnlWatchLater, pnlFavoriteMovies);
                    break;
                case "watch later":
                    getVisisblePanel(pnlWatchLater, pnlSearch, pnlFavoriteMovies);
                    break;
                case "favorite movies":
                    getVisisblePanel(pnlFavoriteMovies, pnlSearch, pnlWatchLater);
                    break;
            }
        }
        private void lblHome_Click(object sender, EventArgs e)
        {
            getVisisblePanel(pnlSearch, pnlWatchLater, pnlFavoriteMovies);
        }

        #endregion

        #region Search
        private void s_txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var searchValue = s_txtSearch.Text;
                var searchMovie = new Search(searchValue);

                var moviePanel = new PanelComponent("", "https://orig00.deviantart.net/d838/f/2011/350/c/2/random_pikachu_by_ieaka-d4jbdkh.png");
                JObject eachMovie;
                Movie movie;
                

                int test = searchMovie.results.Count;
                for (var i = 0; i < test; i++)
                {
                    eachMovie = searchMovie.results[i] as JObject;
                    movie = eachMovie.ToObject<Movie>();

                    // create panels
                    moviePanel = new PanelComponent(movie.Original_Title, "http://image.tmdb.org/t/p/w185/" + movie.Poster_Path);
                    moviePanel.PushElement(s_flwContainer);
                }                                        
            }
        }
        #endregion

        #region Methods

        // Navigation Function
        private void getVisisblePanel(Panel visiblePanel, Panel nvPanelOne, Panel nvPanelTwo)
        {
            visiblePanel.Visible = true;
            nvPanelOne.Visible = false;
            nvPanelTwo.Visible = false;
        }

        #endregion
    }
}
