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
                case "home":
                    getVisisblePanel(pnlHome, pnlSearch, pnlWatchLater, pnlFavoriteMovies);
                    break;
                case "search":
                    getVisisblePanel(pnlSearch, pnlHome, pnlWatchLater, pnlFavoriteMovies);
                    break;
                case "watch later":
                    getVisisblePanel(pnlWatchLater, pnlSearch, pnlHome, pnlFavoriteMovies);
                    break;
                case "favorite movies":
                    getVisisblePanel(pnlFavoriteMovies, pnlSearch, pnlWatchLater, pnlHome);
                    break;
            }
        }
        private void lblHome_Click(object sender, EventArgs e)
        {
            getVisisblePanel(pnlHome, pnlSearch, pnlWatchLater, pnlFavoriteMovies);
        }

        #endregion

        #region Search
        private void s_txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var searchValue = s_txtSearch.Text;
                var test = new Search(searchValue);
                var moviePanel = new PanelComponent();

                moviePanel.PushElement(s_flwContainer);
                richTextBox1.Text = test.GetMovie().ToString();
            }
        }
        #endregion

        #region Methods

        // Navigation Function
        private void getVisisblePanel(Panel visiblePanel, Panel nvPanelOne, Panel nvPanelTwo, Panel nvPanelThree)
        {
            visiblePanel.Visible = true;
            nvPanelOne.Visible = false;
            nvPanelTwo.Visible = false;
            nvPanelThree.Visible = false;
        }

        #endregion
    }
}
