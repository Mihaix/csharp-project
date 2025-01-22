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

namespace supermarket_manager
{
    public partial class SellerForm : Form
    {
        DbConnect dbCon = new DbConnect();
        public SellerForm()
        {
            InitializeComponent();
        }

        private void SelectSeller()
        {
            SqlCommand com = new SqlCommand("SelectSeller", dbCon.GetCon());
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_seller.DataSource = dt;

            com.Dispose();
            adapter.Dispose();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Seller VALUES(" + textBox_id.Text + ", '" + textBox_name.Text + "', '" + textBox_age.Text + "', '" + textBox_pas.Text + "')";
                SqlCommand com = new SqlCommand(insertQuery, dbCon.GetCon());
                dbCon.OpenCon();
                com.ExecuteNonQuery();
                MessageBox.Show("Seller Added");
                dbCon.CloseCon();

                com.Dispose();
                SelectSeller();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            SelectSeller();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE Seller SET SellerName='" + textBox_name.Text + "', SellerAge='" + textBox_age.Text + "', SellerPas='" + textBox_pas.Text + "' WHERE SellerId=" + textBox_id.Text + "";
                SqlCommand com = new SqlCommand(updateQuery, dbCon.GetCon());
                dbCon.OpenCon();
                com.ExecuteNonQuery();
                MessageBox.Show("Seller Updated");
                dbCon.CloseCon();

                com.Dispose();
                SelectSeller();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("DeleteSeller", dbCon.GetCon());
                dbCon.OpenCon();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@param1", textBox_id.Text);
                com.ExecuteNonQuery();

                MessageBox.Show("Seller Deleted");

                dbCon.CloseCon();
                com.Dispose();
                SelectSeller();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
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

        private void button_lg_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            ProductsForm product = new ProductsForm();
            product.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }
    }
}
