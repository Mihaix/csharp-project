using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace supermarket_manager
{
    public partial class LoginForm : Form
    {

        DbConnect dBCon = new DbConnect();

        public static string sellerName;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_select.SelectedIndex > -1)
            {
                if (comboBox_select.SelectedItem.ToString() == "ADMIN")
                {
                    if (textBox_name.Text == "admin" && textBox_pas.Text == "admin123")
                    {
                        ProductsForm product = new ProductsForm();
                        product.Show();
                        this.Hide();

                        ;
                    }
                    else
                    {
                        MessageBox.Show("You are not admin", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    string selectQuery = "SELECT * FROM Seller WHERE SellerName='" + textBox_name.Text + "' AND SellerPas='" + textBox_pas.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        sellerName = textBox_name.Text;
                        SellingForm selling = new SellingForm();
                        selling.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong name or password", "Wrong Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            else
            {
                MessageBox.Show("Select role", "Select role", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
