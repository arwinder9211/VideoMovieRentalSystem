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
    public partial class CustomerForm : Form
    {
        private string CustId;

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(string CustId)
        {
            this.CustId = CustId;
            InitializeComponent();
            button1.Text = "Update Customer";
            DataTable table = new Database().GetCustomer(CustId);
            FName.Text = table.Rows[0]["FirstName"].ToString();
            LName.Text = table.Rows[0]["LastName"].ToString();
            Address.Text = table.Rows[0]["Address"].ToString();
            PhoneNo.Text = table.Rows[0]["Phone"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FName.Text == "" || LName.Text == "" || Address.Text == "" || PhoneNo.Text == "")
            {
                MessageBox.Show("All fields are mandatory.");
            }
            else
            {
                Customer customer = new Customer()
                {
                    FirstName = FName.Text,
                    LastName = LName.Text,
                    Address = Address.Text,
                    Phone = PhoneNo.Text
                };
                Database database = new Database();
                if (button1.Text.ToLower() == "add customer")
                {
                    database.AddCustomer(customer);
                    MessageBox.Show("Customer added successfully");
                }
                else
                {
                    customer.CustID = Convert.ToInt32(CustId);
                    database.UpdateCustomer(customer);
                    MessageBox.Show("Customer updated successfully");
                    Dispose();
                }
            }
        }
    }
}
