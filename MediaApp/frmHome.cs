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

namespace MediaApp
{
    public partial class MovieApp : Form
    {
        string MyConnectionString = "Server=localhost;Database=csc260-finalproject;Uid=root;persistsecurityinfo=True;SslMode=none";

        public MovieApp()
        {
            InitializeComponent();

            // Load in movies from db
            //LoadWatchLaterData();
            //LoadInData("watchlater"); CREATE SINGULAR FUNCTION
            //LoadInData("favorite");

            //InsertData(); MAKE SINGULAR FUNCTION
        }

        #region Navigation
        private void Nav_Buttons(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text.ToLower())
            {
                case "search":
                    getVisisblePanel(pnlSearch, wl_flwContainer, pnlFavoriteMovies);
                    s_txtSearch.Focus();
                    break;
                case "watch later":
                    getVisisblePanel(wl_flwContainer, pnlSearch, pnlFavoriteMovies);
                    break;
                case "favorite movies":
                    getVisisblePanel(pnlFavoriteMovies, pnlSearch, wl_flwContainer);
                    break;
            }
        }
        private void lblHome_Click(object sender, EventArgs e)
        {
            getVisisblePanel(pnlSearch, wl_flwContainer, pnlFavoriteMovies);
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
                                
                for (var i = 0; i < totalResults; i++)
                {
                    eachMovie = searchMovie.results[i] as JObject;
                    movie = eachMovie.ToObject<Movie>();

                    // create panels
                    var moviePanel = new PanelComponent(movie.Original_Title, BASEIMAGEURL + movie.Poster_Path);
                    moviePanel.PushElement(s_flwContainer);
                }
                searchMovie = null;
                searchValue = null;
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

        // Load in data
        private void LoadWatchLaterData()
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * FROM watchlaterdb";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                
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
        private void InsertData()
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO watchlaterdb(MovieID,MovieTitle,MovieImageLink)VALUES(@MovieID,@MovieTitle,@MovieImageLink)";

                cmd.Parameters.AddWithValue("@MovieID", 3);
                cmd.Parameters.AddWithValue("@MovieTitle", "test");
                cmd.Parameters.AddWithValue("@MovieImageLink", "/123abc");

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
