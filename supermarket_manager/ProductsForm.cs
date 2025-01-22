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
    public partial class ProductsForm : Form
    {
        DbConnect dbCon = new DbConnect();
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void SelectProducts()
        {
            SqlCommand com = new SqlCommand("SelectProducts", dbCon.GetCon());
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_products.DataSource = dt;

            com.Dispose();
            adapter.Dispose();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Products VALUES(" + textBox_id.Text + ", '" + textBox_name.Text + "', '" + textBox_price.Text + "', '" + textBox_qty.Text + "', '" + comboBox_category.Text + "')";
                SqlCommand com = new SqlCommand(insertQuery, dbCon.GetCon());
                dbCon.OpenCon();
                com.ExecuteNonQuery();
                MessageBox.Show("Product Added");
                dbCon.CloseCon();

                com.Dispose();
                SelectProducts();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm categ = new CategoryForm();
            categ.Show();
            this.Hide();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            SelectCategory();
            SelectProducts();
        }

        private void SelectCategory()
        {
            SqlCommand com = new SqlCommand("SelectCategory", dbCon.GetCon());
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox_category.DataSource = dt;
            comboBox_category.ValueMember = "CategoryName";
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "CategoryName";

            com.Dispose();
            adapter.Dispose();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE Products SET ProductName='"+textBox_name.Text+"', ProductPrice='"+textBox_price.Text+"', ProductQty='"+textBox_qty.Text+"', ProductCategory='"+comboBox_category.Text+"' WHERE ProductId="+textBox_id.Text+"";
                SqlCommand com = new SqlCommand(updateQuery, dbCon.GetCon());
                dbCon.OpenCon();
                com.ExecuteNonQuery();
                MessageBox.Show("Product Updated");
                dbCon.CloseCon();

                com.Dispose();
                SelectProducts();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("DeleteProduct", dbCon.GetCon());
                dbCon.OpenCon();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@param1", textBox_id.Text);
                com.ExecuteNonQuery();

                MessageBox.Show("Product Deleted");

                dbCon.CloseCon();
                com.Dispose();
                SelectProducts();
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
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Products WHERE ProductCategory='"+comboBox1.SelectedValue.ToString()+"'";
            SqlCommand com = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_products.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectProducts();
        }
    }
}
