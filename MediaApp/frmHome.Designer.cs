namespace MediaApp
{
    partial class MovieApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieApp));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.btnWatchLater = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblHomeTest = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.s_txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlWatchLater = new System.Windows.Forms.Panel();
            this.lblWatchLater = new System.Windows.Forms.Label();
            this.pnlFavoriteMovies = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlWatchLater.SuspendLayout();
            this.pnlFavoriteMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lblHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 65);
            this.panel3.TabIndex = 0;
            // 
            // lblHome
            // 
            this.lblHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(0, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(188, 65);
            this.lblHome.TabIndex = 3;
            this.lblHome.Text = "Movie App";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 90);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 79);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.Nav_Buttons);
            // 
            // btnFavorites
            // 
            this.btnFavorites.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFavorites.FlatAppearance.BorderSize = 0;
            this.btnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorites.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorites.ForeColor = System.Drawing.Color.White;
            this.btnFavorites.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorites.Image")));
            this.btnFavorites.Location = new System.Drawing.Point(2, 327);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(163, 79);
            this.btnFavorites.TabIndex = 1;
            this.btnFavorites.Text = "Favorite Movies";
            this.btnFavorites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.Nav_Buttons);
            // 
            // btnWatchLater
            // 
            this.btnWatchLater.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWatchLater.FlatAppearance.BorderSize = 0;
            this.btnWatchLater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatchLater.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchLater.ForeColor = System.Drawing.Color.White;
            this.btnWatchLater.Image = ((System.Drawing.Image)(resources.GetObject("btnWatchLater.Image")));
            this.btnWatchLater.Location = new System.Drawing.Point(2, 248);
            this.btnWatchLater.Name = "btnWatchLater";
            this.btnWatchLater.Size = new System.Drawing.Size(163, 79);
            this.btnWatchLater.TabIndex = 1;
            this.btnWatchLater.Text = "Watch Later";
            this.btnWatchLater.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWatchLater.UseVisualStyleBackColor = true;
            this.btnWatchLater.Click += new System.EventHandler(this.Nav_Buttons);
            // 
            // btnSearch
            // 
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(0, 169);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 79);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Nav_Buttons);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavigation.Controls.Add(this.btnSearch);
            this.pnlNavigation.Controls.Add(this.btnWatchLater);
            this.pnlNavigation.Controls.Add(this.btnFavorites);
            this.pnlNavigation.Controls.Add(this.btnHome);
            this.pnlNavigation.Controls.Add(this.panel3);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(167, 522);
            this.pnlNavigation.TabIndex = 2;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.lblHomeTest);
            this.pnlHome.Location = new System.Drawing.Point(171, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(622, 522);
            this.pnlHome.TabIndex = 3;
            // 
            // lblHomeTest
            // 
            this.lblHomeTest.Location = new System.Drawing.Point(4, 492);
            this.lblHomeTest.Name = "lblHomeTest";
            this.lblHomeTest.Size = new System.Drawing.Size(78, 22);
            this.lblHomeTest.TabIndex = 4;
            this.lblHomeTest.Text = "Home";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.richTextBox1);
            this.pnlSearch.Controls.Add(this.panel1);
            this.pnlSearch.Controls.Add(this.s_txtSearch);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlSearch.Location = new System.Drawing.Point(170, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(596, 487);
            this.pnlSearch.TabIndex = 5;
            this.pnlSearch.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(47, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 239);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fav";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "WL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fight Club";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // s_txtSearch
            // 
            this.s_txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.s_txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.s_txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_txtSearch.Location = new System.Drawing.Point(124, 37);
            this.s_txtSearch.Multiline = true;
            this.s_txtSearch.Name = "s_txtSearch";
            this.s_txtSearch.Size = new System.Drawing.Size(349, 29);
            this.s_txtSearch.TabIndex = 6;
            this.s_txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.s_txtSearch_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // pnlWatchLater
            // 
            this.pnlWatchLater.Controls.Add(this.lblWatchLater);
            this.pnlWatchLater.Location = new System.Drawing.Point(168, 0);
            this.pnlWatchLater.Name = "pnlWatchLater";
            this.pnlWatchLater.Size = new System.Drawing.Size(527, 408);
            this.pnlWatchLater.TabIndex = 6;
            this.pnlWatchLater.Visible = false;
            // 
            // lblWatchLater
            // 
            this.lblWatchLater.Location = new System.Drawing.Point(384, 352);
            this.lblWatchLater.Name = "lblWatchLater";
            this.lblWatchLater.Size = new System.Drawing.Size(140, 40);
            this.lblWatchLater.TabIndex = 5;
            this.lblWatchLater.Text = "Watch Later";
            // 
            // pnlFavoriteMovies
            // 
            this.pnlFavoriteMovies.Controls.Add(this.label1);
            this.pnlFavoriteMovies.Location = new System.Drawing.Point(169, 0);
            this.pnlFavoriteMovies.Name = "pnlFavoriteMovies";
            this.pnlFavoriteMovies.Size = new System.Drawing.Size(551, 449);
            this.pnlFavoriteMovies.TabIndex = 7;
            this.pnlFavoriteMovies.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(379, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Favorite Movies";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(252, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 362);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // MovieApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(808, 522);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlWatchLater);
            this.Controls.Add(this.pnlFavoriteMovies);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHome);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MovieApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie App";
            this.panel3.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlWatchLater.ResumeLayout(false);
            this.pnlFavoriteMovies.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Button btnWatchLater;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblHomeTest;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlWatchLater;
        private System.Windows.Forms.Panel pnlFavoriteMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWatchLater;
        private System.Windows.Forms.TextBox s_txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

