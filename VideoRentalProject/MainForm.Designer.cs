namespace VideoRentalProject
{
    partial class MainForm
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.LoadMovies = new System.Windows.Forms.Button();
            this.FNTBox = new System.Windows.Forms.TextBox();
            this.LNTBox = new System.Windows.Forms.TextBox();
            this.AdTBox = new System.Windows.Forms.TextBox();
            this.PhTBox = new System.Windows.Forms.TextBox();
            this.FNLabel = new System.Windows.Forms.Label();
            this.LNLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.PhLabel = new System.Windows.Forms.Label();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.UpdCustBtn = new System.Windows.Forms.Button();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.CustIDTBox = new System.Windows.Forms.TextBox();
            this.DltCustBtn = new System.Windows.Forms.Button();
            this.AddMovieBtn = new System.Windows.Forms.Button();
            this.UpdMovieBtn = new System.Windows.Forms.Button();
            this.DltMovieBtn = new System.Windows.Forms.Button();
            this.MovieIDLabel = new System.Windows.Forms.Label();
            this.MovieIDTBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.RatingTBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearTBox = new System.Windows.Forms.TextBox();
            this.RCLabel = new System.Windows.Forms.Label();
            this.RCTBox = new System.Windows.Forms.TextBox();
            this.CopiesLabel = new System.Windows.Forms.Label();
            this.CopiesTBox = new System.Windows.Forms.TextBox();
            this.PlotLabel = new System.Windows.Forms.Label();
            this.PlotTBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreTBox = new System.Windows.Forms.TextBox();
            this.LoadRentedMovie = new System.Windows.Forms.Button();
            this.IssueMovie = new System.Windows.Forms.Button();
            this.ReturnMovie = new System.Windows.Forms.Button();
            this.PopularMovie = new System.Windows.Forms.Button();
            this.Popularcustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(18, 18);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(123, 83);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load Customers";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(18, 111);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersWidth = 62;
            this.MainGrid.Size = new System.Drawing.Size(981, 451);
            this.MainGrid.TabIndex = 1;
            this.MainGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick_1);
            // 
            // LoadMovies
            // 
            this.LoadMovies.Location = new System.Drawing.Point(150, 18);
            this.LoadMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadMovies.Name = "LoadMovies";
            this.LoadMovies.Size = new System.Drawing.Size(123, 83);
            this.LoadMovies.TabIndex = 2;
            this.LoadMovies.Text = "Load Movies";
            this.LoadMovies.UseVisualStyleBackColor = true;
            this.LoadMovies.Click += new System.EventHandler(this.LoadMovies_Click);
            // 
            // FNTBox
            // 
            this.FNTBox.Location = new System.Drawing.Point(567, 618);
            this.FNTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FNTBox.Name = "FNTBox";
            this.FNTBox.Size = new System.Drawing.Size(148, 26);
            this.FNTBox.TabIndex = 3;
            // 
            // LNTBox
            // 
            this.LNTBox.Location = new System.Drawing.Point(408, 683);
            this.LNTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LNTBox.Name = "LNTBox";
            this.LNTBox.Size = new System.Drawing.Size(148, 26);
            this.LNTBox.TabIndex = 4;
            // 
            // AdTBox
            // 
            this.AdTBox.Location = new System.Drawing.Point(567, 683);
            this.AdTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdTBox.Name = "AdTBox";
            this.AdTBox.Size = new System.Drawing.Size(148, 26);
            this.AdTBox.TabIndex = 5;
            // 
            // PhTBox
            // 
            this.PhTBox.Location = new System.Drawing.Point(726, 683);
            this.PhTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhTBox.Name = "PhTBox";
            this.PhTBox.Size = new System.Drawing.Size(148, 26);
            this.PhTBox.TabIndex = 6;
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Location = new System.Drawing.Point(567, 594);
            this.FNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(86, 20);
            this.FNLabel.TabIndex = 7;
            this.FNLabel.Text = "First Name";
            // 
            // LNLabel
            // 
            this.LNLabel.AutoSize = true;
            this.LNLabel.Location = new System.Drawing.Point(404, 658);
            this.LNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNLabel.Name = "LNLabel";
            this.LNLabel.Size = new System.Drawing.Size(86, 20);
            this.LNLabel.TabIndex = 8;
            this.LNLabel.Text = "Last Name";
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Location = new System.Drawing.Point(562, 658);
            this.AdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(68, 20);
            this.AdLabel.TabIndex = 9;
            this.AdLabel.Text = "Address";
            // 
            // PhLabel
            // 
            this.PhLabel.AutoSize = true;
            this.PhLabel.Location = new System.Drawing.Point(722, 658);
            this.PhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhLabel.Name = "PhLabel";
            this.PhLabel.Size = new System.Drawing.Size(55, 20);
            this.PhLabel.TabIndex = 10;
            this.PhLabel.Text = "Phone";
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.Location = new System.Drawing.Point(18, 591);
            this.AddCustBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(93, 83);
            this.AddCustBtn.TabIndex = 11;
            this.AddCustBtn.Text = "Add Customer";
            this.AddCustBtn.UseVisualStyleBackColor = true;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // UpdCustBtn
            // 
            this.UpdCustBtn.Location = new System.Drawing.Point(120, 591);
            this.UpdCustBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdCustBtn.Name = "UpdCustBtn";
            this.UpdCustBtn.Size = new System.Drawing.Size(93, 83);
            this.UpdCustBtn.TabIndex = 12;
            this.UpdCustBtn.Text = "Update Customer";
            this.UpdCustBtn.UseVisualStyleBackColor = true;
            this.UpdCustBtn.Click += new System.EventHandler(this.UpdCustBtn_Click);
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Location = new System.Drawing.Point(408, 594);
            this.CustIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(99, 20);
            this.CustIDLabel.TabIndex = 14;
            this.CustIDLabel.Text = "Customer ID";
            // 
            // CustIDTBox
            // 
            this.CustIDTBox.Enabled = false;
            this.CustIDTBox.Location = new System.Drawing.Point(386, 618);
            this.CustIDTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustIDTBox.Name = "CustIDTBox";
            this.CustIDTBox.Size = new System.Drawing.Size(148, 26);
            this.CustIDTBox.TabIndex = 13;
            // 
            // DltCustBtn
            // 
            this.DltCustBtn.Location = new System.Drawing.Point(222, 591);
            this.DltCustBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DltCustBtn.Name = "DltCustBtn";
            this.DltCustBtn.Size = new System.Drawing.Size(93, 83);
            this.DltCustBtn.TabIndex = 15;
            this.DltCustBtn.Text = "Delete Customer";
            this.DltCustBtn.UseVisualStyleBackColor = true;
            this.DltCustBtn.Click += new System.EventHandler(this.DltCustBtn_Click);
            // 
            // AddMovieBtn
            // 
            this.AddMovieBtn.Location = new System.Drawing.Point(18, 746);
            this.AddMovieBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddMovieBtn.Name = "AddMovieBtn";
            this.AddMovieBtn.Size = new System.Drawing.Size(93, 83);
            this.AddMovieBtn.TabIndex = 16;
            this.AddMovieBtn.Text = "Add Movie";
            this.AddMovieBtn.UseVisualStyleBackColor = true;
            this.AddMovieBtn.Click += new System.EventHandler(this.AddMovieBtn_Click);
            // 
            // UpdMovieBtn
            // 
            this.UpdMovieBtn.Location = new System.Drawing.Point(120, 746);
            this.UpdMovieBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdMovieBtn.Name = "UpdMovieBtn";
            this.UpdMovieBtn.Size = new System.Drawing.Size(93, 83);
            this.UpdMovieBtn.TabIndex = 17;
            this.UpdMovieBtn.Text = "Update Movie";
            this.UpdMovieBtn.UseVisualStyleBackColor = true;
            this.UpdMovieBtn.Click += new System.EventHandler(this.UpdMovieBtn_Click);
            // 
            // DltMovieBtn
            // 
            this.DltMovieBtn.Location = new System.Drawing.Point(222, 746);
            this.DltMovieBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DltMovieBtn.Name = "DltMovieBtn";
            this.DltMovieBtn.Size = new System.Drawing.Size(93, 83);
            this.DltMovieBtn.TabIndex = 18;
            this.DltMovieBtn.Text = "Delete Movie";
            this.DltMovieBtn.UseVisualStyleBackColor = true;
            this.DltMovieBtn.Click += new System.EventHandler(this.DltMovieBtn_Click);
            // 
            // MovieIDLabel
            // 
            this.MovieIDLabel.AutoSize = true;
            this.MovieIDLabel.Location = new System.Drawing.Point(391, 724);
            this.MovieIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieIDLabel.Name = "MovieIDLabel";
            this.MovieIDLabel.Size = new System.Drawing.Size(71, 20);
            this.MovieIDLabel.TabIndex = 19;
            this.MovieIDLabel.Text = "Movie ID";
            // 
            // MovieIDTBox
            // 
            this.MovieIDTBox.Enabled = false;
            this.MovieIDTBox.Location = new System.Drawing.Point(386, 749);
            this.MovieIDTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieIDTBox.Name = "MovieIDTBox";
            this.MovieIDTBox.Size = new System.Drawing.Size(148, 26);
            this.MovieIDTBox.TabIndex = 20;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(553, 724);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(56, 20);
            this.RatingLabel.TabIndex = 21;
            this.RatingLabel.Text = "Rating";
            // 
            // RatingTBox
            // 
            this.RatingTBox.Location = new System.Drawing.Point(557, 746);
            this.RatingTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RatingTBox.Name = "RatingTBox";
            this.RatingTBox.Size = new System.Drawing.Size(148, 26);
            this.RatingTBox.TabIndex = 22;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(722, 724);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel.TabIndex = 23;
            this.TitleLabel.Text = "Title";
            // 
            // TitleTBox
            // 
            this.TitleTBox.Location = new System.Drawing.Point(726, 749);
            this.TitleTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleTBox.Name = "TitleTBox";
            this.TitleTBox.Size = new System.Drawing.Size(148, 26);
            this.TitleTBox.TabIndex = 24;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(904, 724);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(43, 20);
            this.YearLabel.TabIndex = 25;
            this.YearLabel.Text = "Year";
            // 
            // YearTBox
            // 
            this.YearTBox.Location = new System.Drawing.Point(895, 749);
            this.YearTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YearTBox.Name = "YearTBox";
            this.YearTBox.Size = new System.Drawing.Size(148, 26);
            this.YearTBox.TabIndex = 26;
            // 
            // RCLabel
            // 
            this.RCLabel.AutoSize = true;
            this.RCLabel.Location = new System.Drawing.Point(392, 780);
            this.RCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RCLabel.Name = "RCLabel";
            this.RCLabel.Size = new System.Drawing.Size(98, 20);
            this.RCLabel.TabIndex = 27;
            this.RCLabel.Text = "Rental_Cost";
            // 
            // RCTBox
            // 
            this.RCTBox.Location = new System.Drawing.Point(386, 805);
            this.RCTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RCTBox.Name = "RCTBox";
            this.RCTBox.Size = new System.Drawing.Size(148, 26);
            this.RCTBox.TabIndex = 28;
            // 
            // CopiesLabel
            // 
            this.CopiesLabel.AutoSize = true;
            this.CopiesLabel.Location = new System.Drawing.Point(555, 780);
            this.CopiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopiesLabel.Name = "CopiesLabel";
            this.CopiesLabel.Size = new System.Drawing.Size(58, 20);
            this.CopiesLabel.TabIndex = 29;
            this.CopiesLabel.Text = "Copies";
            // 
            // CopiesTBox
            // 
            this.CopiesTBox.Location = new System.Drawing.Point(557, 805);
            this.CopiesTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CopiesTBox.Name = "CopiesTBox";
            this.CopiesTBox.Size = new System.Drawing.Size(148, 26);
            this.CopiesTBox.TabIndex = 30;
            // 
            // PlotLabel
            // 
            this.PlotLabel.AutoSize = true;
            this.PlotLabel.Location = new System.Drawing.Point(722, 780);
            this.PlotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlotLabel.Name = "PlotLabel";
            this.PlotLabel.Size = new System.Drawing.Size(36, 20);
            this.PlotLabel.TabIndex = 31;
            this.PlotLabel.Text = "Plot";
            // 
            // PlotTBox
            // 
            this.PlotTBox.Location = new System.Drawing.Point(726, 805);
            this.PlotTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlotTBox.Name = "PlotTBox";
            this.PlotTBox.Size = new System.Drawing.Size(148, 26);
            this.PlotTBox.TabIndex = 32;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(904, 777);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(54, 20);
            this.GenreLabel.TabIndex = 33;
            this.GenreLabel.Text = "Genre";
            // 
            // GenreTBox
            // 
            this.GenreTBox.Location = new System.Drawing.Point(895, 805);
            this.GenreTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenreTBox.Name = "GenreTBox";
            this.GenreTBox.Size = new System.Drawing.Size(148, 26);
            this.GenreTBox.TabIndex = 34;
            // 
            // LoadRentedMovie
            // 
            this.LoadRentedMovie.Location = new System.Drawing.Point(281, 18);
            this.LoadRentedMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadRentedMovie.Name = "LoadRentedMovie";
            this.LoadRentedMovie.Size = new System.Drawing.Size(123, 83);
            this.LoadRentedMovie.TabIndex = 35;
            this.LoadRentedMovie.Text = "Load Rented Movies";
            this.LoadRentedMovie.UseVisualStyleBackColor = true;
            this.LoadRentedMovie.Click += new System.EventHandler(this.LoadRentedMovie_Click);
            // 
            // IssueMovie
            // 
            this.IssueMovie.Location = new System.Drawing.Point(530, 18);
            this.IssueMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IssueMovie.Name = "IssueMovie";
            this.IssueMovie.Size = new System.Drawing.Size(123, 83);
            this.IssueMovie.TabIndex = 36;
            this.IssueMovie.Text = "Issue Movie";
            this.IssueMovie.UseVisualStyleBackColor = true;
            this.IssueMovie.Click += new System.EventHandler(this.IssueMovie_Click);
            // 
            // ReturnMovie
            // 
            this.ReturnMovie.Location = new System.Drawing.Point(677, 18);
            this.ReturnMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReturnMovie.Name = "ReturnMovie";
            this.ReturnMovie.Size = new System.Drawing.Size(123, 83);
            this.ReturnMovie.TabIndex = 37;
            this.ReturnMovie.Text = "Return Movie";
            this.ReturnMovie.UseVisualStyleBackColor = true;
            this.ReturnMovie.Click += new System.EventHandler(this.ReturnMovie_Click);
            // 
            // PopularMovie
            // 
            this.PopularMovie.Location = new System.Drawing.Point(835, 18);
            this.PopularMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PopularMovie.Name = "PopularMovie";
            this.PopularMovie.Size = new System.Drawing.Size(123, 83);
            this.PopularMovie.TabIndex = 38;
            this.PopularMovie.Text = "Popular Movie";
            this.PopularMovie.UseVisualStyleBackColor = true;
            this.PopularMovie.Click += new System.EventHandler(this.PopularMovie_Click);
            // 
            // Popularcustomer
            // 
            this.Popularcustomer.Location = new System.Drawing.Point(992, 18);
            this.Popularcustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Popularcustomer.Name = "Popularcustomer";
            this.Popularcustomer.Size = new System.Drawing.Size(123, 83);
            this.Popularcustomer.TabIndex = 39;
            this.Popularcustomer.Text = "Popular Customer";
            this.Popularcustomer.UseVisualStyleBackColor = true;
            this.Popularcustomer.Click += new System.EventHandler(this.Popularcustomer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 867);
            this.Controls.Add(this.Popularcustomer);
            this.Controls.Add(this.PopularMovie);
            this.Controls.Add(this.ReturnMovie);
            this.Controls.Add(this.IssueMovie);
            this.Controls.Add(this.LoadRentedMovie);
            this.Controls.Add(this.GenreTBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.PlotTBox);
            this.Controls.Add(this.PlotLabel);
            this.Controls.Add(this.CopiesTBox);
            this.Controls.Add(this.CopiesLabel);
            this.Controls.Add(this.RCTBox);
            this.Controls.Add(this.RCLabel);
            this.Controls.Add(this.YearTBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.TitleTBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RatingTBox);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.MovieIDTBox);
            this.Controls.Add(this.MovieIDLabel);
            this.Controls.Add(this.DltMovieBtn);
            this.Controls.Add(this.UpdMovieBtn);
            this.Controls.Add(this.AddMovieBtn);
            this.Controls.Add(this.DltCustBtn);
            this.Controls.Add(this.CustIDLabel);
            this.Controls.Add(this.CustIDTBox);
            this.Controls.Add(this.UpdCustBtn);
            this.Controls.Add(this.AddCustBtn);
            this.Controls.Add(this.PhLabel);
            this.Controls.Add(this.AdLabel);
            this.Controls.Add(this.LNLabel);
            this.Controls.Add(this.FNLabel);
            this.Controls.Add(this.PhTBox);
            this.Controls.Add(this.AdTBox);
            this.Controls.Add(this.LNTBox);
            this.Controls.Add(this.FNTBox);
            this.Controls.Add(this.LoadMovies);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.LoadBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Video Rental";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button LoadMovies;
        private System.Windows.Forms.TextBox FNTBox;
        private System.Windows.Forms.TextBox LNTBox;
        private System.Windows.Forms.TextBox AdTBox;
        private System.Windows.Forms.TextBox PhTBox;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.Label LNLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label PhLabel;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.Button UpdCustBtn;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.TextBox CustIDTBox;
        private System.Windows.Forms.Button DltCustBtn;
        private System.Windows.Forms.Button AddMovieBtn;
        private System.Windows.Forms.Button UpdMovieBtn;
        private System.Windows.Forms.Button DltMovieBtn;
        private System.Windows.Forms.Label MovieIDLabel;
        private System.Windows.Forms.TextBox MovieIDTBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox RatingTBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox YearTBox;
        private System.Windows.Forms.Label RCLabel;
        private System.Windows.Forms.TextBox RCTBox;
        private System.Windows.Forms.Label CopiesLabel;
        private System.Windows.Forms.TextBox CopiesTBox;
        private System.Windows.Forms.Label PlotLabel;
        private System.Windows.Forms.TextBox PlotTBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox GenreTBox;
        private System.Windows.Forms.Button LoadRentedMovie;
        private System.Windows.Forms.Button IssueMovie;
        private System.Windows.Forms.Button ReturnMovie;
        private System.Windows.Forms.Button PopularMovie;
        private System.Windows.Forms.Button Popularcustomer;
    }
}

