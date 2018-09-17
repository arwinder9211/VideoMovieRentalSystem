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
    public partial class BestMoviesForm : Form
    {
        public BestMoviesForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Database().GetBestMovies();
        }
    }
}
