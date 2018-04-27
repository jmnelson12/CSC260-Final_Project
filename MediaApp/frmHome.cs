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
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace MediaApp
{
    public partial class MovieApp : Form
    {
        private string MyConnectionString = "Server=localhost;Database=csc260-finalproject;Uid=root;persistsecurityinfo=True;SslMode=none";

        public MovieApp()
        {
            InitializeComponent();

            // Load in movies from db
            LoadWatchLaterData("watchlaterdb");
            // LoadInData("watchlater"); CREATE SINGULAR FUNCTION
            // LoadInData("favorite");
        }

        #region Navigation
        private void Nav_Buttons(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text.ToLower())
            {
                case "search":
                    getVisisblePanel(pnlSearch, pnlWatchLater, pnlFavoriteMovies);
                    s_txtSearch.Focus();
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
                // Declarations
                var searchValue = s_txtSearch.Text;
                var searchMovie = new Search(searchValue);
                const string BASEIMAGEURL = "http://image.tmdb.org/t/p/w185/";
                int totalResults = searchMovie.results.Count;

                JObject eachMovie;
                Movie movie;
                               
                // Loop through results
                for (var i = 0; i < totalResults; i++)
                {
                    eachMovie = searchMovie.results[i] as JObject;
                    movie = eachMovie.ToObject<Movie>();

                    // create panels
                    var moviePanel = new PanelComponent(movie.Original_Title, BASEIMAGEURL + movie.Poster_Path);                    
                    moviePanel.PushElement(s_flwContainer);                              
                }
                addBtnFunctionality();
                searchMovie = null;
                searchValue = null;
            }            
        }
        #endregion

        #region Methods

        // Add functionality to dynamically created buttons
        private void addBtnFunctionality() {
            foreach (Control c in s_flwContainer.Controls) {
                if (c.Name == "basePanel") {
                    var wl_button = c.GetChildAtPoint(new Point(13, 200));
                    var fav_button = c.GetChildAtPoint(new Point(93, 200));

                    wl_button.Click += new EventHandler(WatchLater_Click);
                    fav_button.Click += new EventHandler(Favorite_Click);
                }
            }
        }

        // Favorite btn Clicked
        private void Favorite_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            var fav_MovieTitle = button.Parent.GetChildAtPoint(new Point(3, 154)).Text;
            var fav_MovieImage = button.Parent.GetChildAtPoint(new Point(1, 1)).Name;

            pushToPanel(fav_MovieTitle, fav_MovieImage, f_flwContainer, "fav");
        }

        // Watch Later btn clicked
        private void WatchLater_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var wl_MovieTitle = button.Parent.GetChildAtPoint(new Point(3, 154)).Text;
            var wl_MovieImage = button.Parent.GetChildAtPoint(new Point(1, 1)).Name;

            pushToPanel(wl_MovieTitle, wl_MovieImage, wl_flwContainer, "wl");
        }

        // Push Panel to correct place
        private void pushToPanel(string movieTitle, string movieImage, FlowLayoutPanel pnl, string type)
        {
            var moviePanel = new PanelComponent(movieTitle, movieImage);
            moviePanel.PushElement(pnl);

            // Insert Data into DB
            InsertData(type, movieTitle, movieImage);
        }

        // Navigation Function
        private void getVisisblePanel(Panel visiblePanel, Panel nvPanelOne, Panel nvPanelTwo)
        {
            visiblePanel.Visible = true;
            nvPanelOne.Visible = false;
            nvPanelTwo.Visible = false;
        }

        // Load in data
        private void LoadWatchLaterData(string db)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * FROM " + db;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var moviePanel = new PanelComponent(reader[1].ToString(), reader[2].ToString());
                        moviePanel.PushElement(wl_flwContainer);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }            
        }

        // Insert Data
        private void InsertData(string type, string movieTitle, string movieImage)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                if (type == "wl")
                {
                    cmd.CommandText = "INSERT INTO watchlaterdb(MovieTitle,MovieImageLink)VALUES(@MovieTitle,@MovieImageLink)";
                }
                else if (type == "fav") {
                    cmd.CommandText = "INSERT INTO favoritemoviedb(MovieTitle,MovieImageLink)VALUES(@MovieTitle,@MovieImageLink)";
                }

                cmd.Parameters.AddWithValue("@MovieTitle", movieTitle);
                cmd.Parameters.AddWithValue("@MovieImageLink", movieImage);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();              
                }
            }
        }

        #endregion
    }
}
