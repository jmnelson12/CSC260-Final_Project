using System;
using System.Collections.Generic;
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

        #region Contructors
        public PanelComponent()
        {
            // Base Panel
            this.basePanel.Size = new Size(178, 239);

            // Base Panel Elements
            this.picMovieLogo.Size = new Size(178, 147);
            this.lblMovieTitle.Size = new Size(172, 32);
            this.btnWatchLater.Size = new Size(74, 27);
            this.btnFavorite.Size = new Size(74, 27);

            // Add Elements To Base Panel
            this.basePanel.Controls.Add(this.picMovieLogo);
            this.basePanel.Controls.Add(this.lblMovieTitle);
            this.basePanel.Controls.Add(this.btnWatchLater);
            this.basePanel.Controls.Add(this.btnFavorite);

        }
        public PanelComponent(string titleOfMovie, string movieImage)
        {
            // Base Panel
            this.basePanel.Size = new Size(178, 239);

            // Base Panel Elements
            this.picMovieLogo.Size = new Size(178, 147);
            this.lblMovieTitle.Size = new Size(172, 32);
            this.btnWatchLater.Size = new Size(74, 27);
            this.btnFavorite.Size = new Size(74, 27);

            // Add Elements To Base Panel
            this.basePanel.Controls.Add(this.picMovieLogo);
            this.basePanel.Controls.Add(this.lblMovieTitle);
            this.basePanel.Controls.Add(this.btnWatchLater);
            this.basePanel.Controls.Add(this.btnFavorite);

        }
        #endregion

        #region Methods
        public void pushContainers(string loc)
        {
             
        }
        #endregion

    }
}
