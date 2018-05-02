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
        Button btnRemove = new Button();

        #region Contructors
        public PanelComponent(string titleOfMovie, string movieImage, bool type)
        {
            var margin = this.basePanel.Margin;
            margin.All = 8;
            this.basePanel.Margin = margin;      

            // Base Panel
            this.basePanel.Size = new Size(178, 239);
            this.basePanel.BorderStyle = BorderStyle.FixedSingle;
            this.basePanel.Name = "basePanel";

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

            if (!type)
            {
                // Watch Later Button
                this.btnWatchLater.Size = new Size(74, 27);
                this.btnWatchLater.Location = new Point(12, 199);
                this.btnWatchLater.Text = "WL";
                this.btnWatchLater.BackColor = Color.LightGray;

                // Favorite Button
                this.btnFavorite.Size = new Size(74, 27);
                this.btnFavorite.Location = new Point(92, 199);
                this.btnFavorite.Text = "Fav";
                this.btnFavorite.BackColor = Color.LightGray;
            }
            else
            {
                this.btnRemove.Size = new Size(85, 27);
                this.btnRemove.Location = new Point(44, 199);
                this.btnRemove.Text = "Remove";
                this.btnRemove.BackColor = Color.LightGray;
            }

            // Add Elements To Base Panel
            this.basePanel.Controls.Add(this.picMovieLogo);
            this.basePanel.Controls.Add(this.lblMovieTitle);
            this.basePanel.Controls.Add(this.btnWatchLater);
            this.basePanel.Controls.Add(this.btnFavorite);
            this.basePanel.Controls.Add(this.btnRemove);
        }
        #endregion

        #region Methods
        public void PushElement(Panel pageAddingTo)
        {
            pageAddingTo.Controls.Add(this.basePanel);
        }
        #endregion
    }
}
