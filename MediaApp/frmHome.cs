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
                //var test = new Movie();
                var movies = new Search(searchValue);

                // create panels
                var moviePanel = new PanelComponent("title", "https://orig00.deviantart.net/d838/f/2011/350/c/2/random_pikachu_by_ieaka-d4jbdkh.png");                
                moviePanel.PushElement(s_flwContainer);

                richTextBox1.Text = movies.total_results + "\n\n" + movies.results;
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
