using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalProject
{
    public partial class MainForm : Form
    {
        DB Database = new DB();

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadCustomers();
        }

        private void LoadMovies_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadMovies();
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            Database.AddCustomer(FNTBox.Text, LNTBox.Text, PhTBox.Text, AdTBox.Text);
            LoadBtn_Click(null, null);
        }

        private void UpdCustBtn_Click(object sender, EventArgs e)
        {
            Database.UpdateCustomer(CustIDTBox.Text, FNTBox.Text, LNTBox.Text, PhTBox.Text, AdTBox.Text);
            LoadBtn_Click(null, null);
        }

        
        private void DltCustBtn_Click(object sender, EventArgs e)
        {
            Database.DeleteCustomer(CustIDTBox.Text);
            LoadBtn_Click(null, null);
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = MainGrid.Rows[index];

           if(row.Cells.Count ==5)
            { 
            CustIDTBox.Text = row.Cells[0].Value.ToString();
            FNTBox.Text = row.Cells[1].Value.ToString();
            LNTBox.Text = row.Cells[2].Value.ToString();
            AdTBox.Text = row.Cells[3].Value.ToString();
            PhTBox.Text = row.Cells[4].Value.ToString();
            }
           else
                if (row.Cells.Count == 8)
            { 

                MovieIDTBox.Text = row.Cells[0].Value.ToString();
            RatingTBox.Text = row.Cells[1].Value.ToString();
            TitleTBox.Text = row.Cells[2].Value.ToString();
            YearTBox.Text = row.Cells[3].Value.ToString();
            RCTBox.Text = row.Cells[4].Value.ToString();
            CopiesTBox.Text = row.Cells[5].Value.ToString();
            PlotTBox.Text = row.Cells[6].Value.ToString();
            GenreTBox.Text = row.Cells[7].Value.ToString();
            }

        }

        private void AddMovieBtn_Click(object sender, EventArgs e)
        {
            Database.AddMovie(RatingTBox.Text, TitleTBox.Text, YearTBox.Text, RCTBox.Text, CopiesTBox.Text, PlotTBox.Text, GenreTBox.Text);
            LoadBtn_Click(null, null);
        }

        private void UpdMovieBtn_Click(object sender, EventArgs e)
        {
            Database.UpdateMovie(MovieIDTBox.Text, RatingTBox.Text, TitleTBox.Text, YearTBox.Text, RCTBox.Text, CopiesTBox.Text, PlotTBox.Text, GenreTBox.Text);
            LoadBtn_Click(null, null);
        }

        private void DltMovieBtn_Click(object sender, EventArgs e)
        {
            Database.DeleteMovie(MovieIDTBox.Text);
            LoadBtn_Click(null, null);
        }

        private void MainGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
