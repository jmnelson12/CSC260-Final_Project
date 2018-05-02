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
        private const string _MYCONNECTIONSTRING = "Server=localhost;Database=csc260-finalproject;Uid=root;persistsecurityinfo=True;SslMode=none";

        public MovieApp()
        {
            InitializeComponent();

            // Load in movies from db
            LoadInData("moviedb");                       
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
                // Clear Panel
                s_flwContainer.Controls.Clear();

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
                    var moviePanel = new PanelComponent(movie.Original_Title, BASEIMAGEURL + movie.Poster_Path, false);
                    moviePanel.PushElement(s_flwContainer);
                }
                addBtnFunctionality();

                searchMovie = null;
                s_txtSearch.Text = null;
                totalResults = 0;
                eachMovie = null;
                movie = null;                
            }
        }

        #endregion

        #region Methods

        // Remove Button Functionality
        private void addRemoveBtnFunctionality()
        {
            // Add functionality to controls in flow container
            foreach (Control c in f_flwContainer.Controls)
            {
                if (c.Name == "basePanel")
                {
                    foreach (Control con in c.Controls) {
                        if (con.Text == "Remove") {
                            con.Click += new EventHandler(Remove_Click);
                        }
                    }
                }
            }

            // Add functionality to controls in watch later container
            foreach (Control c in wl_flwContainer.Controls)
            {
                if (c.Name == "basePanel")
                {
                    foreach (Control con in c.Controls)
                    {
                        if (con.Text == "Remove")
                        {
                            con.Click += new EventHandler(Remove_Click);
                        }
                    }
                }
            }
        }

        // Add functionality to dynamically created buttons
        private void addBtnFunctionality()
        {
            foreach (Control c in s_flwContainer.Controls)
            {
                if (c.Name == "basePanel")
                {
                    var wl_button = c.GetChildAtPoint(new Point(13, 200));
                    var fav_button = c.GetChildAtPoint(new Point(93, 200));

                    wl_button.Click += new EventHandler(WatchLater_Click);
                    fav_button.Click += new EventHandler(Favorite_Click);
                }
            }
        }

        // Favorite btn Clicked
        private void Favorite_Click(object sender, EventArgs e)
        {
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

        // Remove btn clicked
        private void Remove_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var siblings = button.Parent.Controls;
            string parentPanelName = button.Parent.Parent.Parent.Name;
            string movieTitle = null;
            string movieType = null;

            // Get Panel that control is in
            movieType = (parentPanelName == "pnlFavoriteMovies") ? "fav" : "wl";

            // Get Movie Title
            foreach (Control c in siblings)
            {
                if (c.GetType() == typeof(Label)) {
                    movieTitle = c.Text;
                }
            }

            // Remove Movie from db
            MySqlConnection con = new MySqlConnection(_MYCONNECTIONSTRING);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM moviedb WHERE MovieTitle='" + movieTitle + "' AND MovieType='" + movieType + "'";
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

            // testing
            button.Parent.Visible = false;
        }

        // Push Panel to correct location
        private void pushToPanel(string movieTitle, string movieImage, FlowLayoutPanel pnl, string type)
        {
            var moviePanel = new PanelComponent(movieTitle, movieImage, true);
            moviePanel.PushElement(pnl);

            addRemoveBtnFunctionality();

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

        // Load in data from DB       
        private void LoadInData(string db)
        {
            MySqlConnection con = new MySqlConnection(_MYCONNECTIONSTRING);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * FROM " + db;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var moviePanel = new PanelComponent(reader[1].ToString(), reader[2].ToString(), true);
                        if (reader[3].ToString() == "wl")
                        {
                            moviePanel.PushElement(wl_flwContainer);
                        }
                        else if (reader[3].ToString() == "fav")
                        {
                            moviePanel.PushElement(f_flwContainer);
                        }
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
            addRemoveBtnFunctionality();
        }

        // Insert Data into DB
        private void InsertData(string type, string movieTitle, string movieImage)
        {
            MySqlConnection con = new MySqlConnection(_MYCONNECTIONSTRING);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO moviedb(MovieTitle,MovieImageLink,MovieType)VALUES(@MovieTitle,@MovieImageLink,@MovieType)";

                cmd.Parameters.AddWithValue("@MovieType", type == "wl" ? "wl" : "fav");
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
