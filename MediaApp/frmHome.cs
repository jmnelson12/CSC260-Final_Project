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

            //Panel test = new Panel();
            //test.BackColor = Color.Red;
            //test.Size = new Size(178, 239);
            //test.Location = new Point(0, 0);
            //pnlSearch.Controls.Add(test);

        }

        #region Navigation
        private void Nav_Buttons(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text.ToLower())
            {
                case "home":
                    pnlHome.Visible = true;
                    pnlSearch.Visible = false;
                    pnlWatchLater.Visible = false;
                    pnlFavoriteMovies.Visible = false;
                    break;
                case "search":
                    pnlSearch.Visible = true;
                    pnlHome.Visible = false;
                    pnlWatchLater.Visible = false;
                    pnlFavoriteMovies.Visible = false;
                    break;
                case "watch later":
                    pnlWatchLater.Visible = true;
                    pnlHome.Visible = false;
                    pnlSearch.Visible = false;
                    pnlFavoriteMovies.Visible = false;
                    break;
                case "favorite movies":
                    pnlFavoriteMovies.Visible = true;
                    pnlHome.Visible = false;
                    pnlSearch.Visible = false;
                    pnlWatchLater.Visible = false;
                    break;
            }
        }
        private void lblHome_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = true;
            pnlSearch.Visible = false;
            pnlWatchLater.Visible = false;
            pnlFavoriteMovies.Visible = false;
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


                richTextBox1.Text = test.GetMovie().ToString();
            }
        }
        #endregion

        #region Methods

        #endregion
    }
}
