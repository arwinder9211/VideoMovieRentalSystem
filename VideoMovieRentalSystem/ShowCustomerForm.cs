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
    public partial class ShowCustomerForm : Form
    {
        public ShowCustomerForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Database().GetCustomers();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm edit = new CustomerForm(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            edit.ShowDialog();
            dataGridView1.DataSource = new Database().GetCustomers();
        }
    }
}
