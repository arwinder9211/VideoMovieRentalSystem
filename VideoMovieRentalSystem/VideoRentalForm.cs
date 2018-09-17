using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMovieRentalSystem
{
    public partial class VideoRentalForm : Form
    {
        public VideoRentalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowCustomerForm showCustomerForm = new ShowCustomerForm();
            showCustomerForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowMovieForm showMovieForm = new ShowMovieForm();
            showMovieForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowMovieForm showMovieForm = new ShowMovieForm();
            showMovieForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReturnForm returnForm = new ReturnForm();
            returnForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BestCustomerForm bestCustomerForm = new BestCustomerForm();
            bestCustomerForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BestMoviesForm bestMoviesForm = new BestMoviesForm();
            bestMoviesForm.ShowDialog();
        }
    }
}
