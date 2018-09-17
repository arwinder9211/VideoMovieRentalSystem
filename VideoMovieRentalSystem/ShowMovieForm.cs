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
    public partial class ShowMovieForm : Form
    {
        public ShowMovieForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Database().GetMovies();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieForm edit = new MovieForm(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            edit.ShowDialog();
            dataGridView1.DataSource = new Database().GetMovies();
        }

        private void issueVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Copies = new Database().GetAvaliableCopies(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            if (Copies > 0)
            {
                IssueForm issue = new IssueForm(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                issue.ShowDialog();
            }
            else
            {
                MessageBox.Show("No copies available to issue");
            }
        }
    }
}
