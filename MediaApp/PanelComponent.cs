using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaApp
{
    class PanelComponent
    {
        Panel basePanel = new Panel();
        PictureBox picMovieLogo = new PictureBox();
        Label lblMovieTitle = new Label();
        Button btnWatchLater = new Button();
        Button btnFavorite = new Button();
        int count = 0;

        #region Contructors
        public PanelComponent(string titleOfMovie, string movieImage)
        {
            var margin = this.basePanel.Margin;
            margin.All = 8;
            this.basePanel.Margin = margin;      
            count++;

            // Base Panel
            this.basePanel.Size = new Size(178, 239);
            this.basePanel.BorderStyle = BorderStyle.FixedSingle;

            // Movie Logo element
            this.picMovieLogo.Size = new Size(178, 147);
            this.picMovieLogo.LoadAsync(movieImage);
            this.picMovieLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picMovieLogo.Name = movieImage;

            // Movie Label
            this.lblMovieTitle.Size = new Size(172, 46);
            this.lblMovieTitle.AutoSize = false;
            this.lblMovieTitle.Location = new Point(3, 154);
            this.lblMovieTitle.Text = titleOfMovie;
            this.lblMovieTitle.Font = new Font("Arial", 10);
            this.lblMovieTitle.TextAlign = ContentAlignment.TopCenter;

            // Watch Later Button
            this.btnWatchLater.Size = new Size(74, 27);
            this.btnWatchLater.Location = new Point(12, 199);
            this.btnWatchLater.Text = "WL";
            this.btnWatchLater.BackColor = Color.LightGray;
            this.btnWatchLater.Click += new EventHandler(WatchLater_Click);

            // Favorite Button
            this.btnFavorite.Size = new Size(74, 27);
            this.btnFavorite.Location = new Point(92, 199);
            this.btnFavorite.Text = "Fav";
            this.btnFavorite.BackColor = Color.LightGray;

            // Add Elements To Base Panel
            this.basePanel.Controls.Add(this.picMovieLogo);
            this.basePanel.Controls.Add(this.lblMovieTitle);
            this.basePanel.Controls.Add(this.btnWatchLater);
            this.basePanel.Controls.Add(this.btnFavorite);
        }
        #endregion

        #region Methods
        public void PushElement(Panel pageAddingTo)
        {
            pageAddingTo.Controls.Add(this.basePanel);
        }

        private void WatchLater_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var wl_MovieTitle = button.Parent.GetChildAtPoint(new Point(3, 154)).Text;
            var wl_MovieImage = button.Parent.GetChildAtPoint(new Point(1, 1)).Name;

            var moviePanel = new PanelComponent(wl_MovieTitle, wl_MovieImage);
            //moviePanel.PushElement();

            Debug.WriteLine(wl_MovieImage);
        }
        #endregion
    }
}
