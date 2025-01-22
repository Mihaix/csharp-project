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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace supermarket_manager
{
    public partial class SellingForm : Form
    {

        DbConnect dbCon = new DbConnect();
        public SellingForm()
        {
            InitializeComponent();
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

            com.Dispose();
            adapter.Dispose();
        }

        private void SelectBill()
        {
            string selectQuery = "SELECT * FROM Bill";
            SqlCommand com = new SqlCommand(selectQuery, dbCon.GetCon());

            SqlDataAdapter adapter = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_sellList.DataSource = dt;

            com.Dispose();
            adapter.Dispose();
        }

        private void SelectProducts()
        {
            SqlCommand com = new SqlCommand("SelectProductDif", dbCon.GetCon());
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_products.DataSource = dt;

            com.Dispose();
            adapter.Dispose();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString().Substring(5);
            label_seller.Text = LoginForm.sellerName;

            SelectProducts();
            SelectCategory();
            SelectBill();
        }

        int total = 0, n = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES(" + textBox_id.Text + ", '" + label_seller.Text + "', '" + label_date.Text + "', '"+total.ToString()+"')";
                SqlCommand com = new SqlCommand(insertQuery, dbCon.GetCon());
                dbCon.OpenCon();
                com.ExecuteNonQuery();
                MessageBox.Show("Bill Added");
                dbCon.CloseCon();

                com.Dispose();
                SelectBill();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView_products_Click(object sender, EventArgs e)
        {
            textBox_name.Text = dataGridView_products.SelectedRows[0].Cells[0].Value.ToString();
            textBox_price.Text = dataGridView_products.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button_lg_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT ProductName, ProductPrice FROM Products WHERE ProductCategory='" + comboBox_category.SelectedValue.ToString() + "'";
            SqlCommand com = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_products.DataSource = table;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int Total = Convert.ToInt32(textBox_price.Text) * Convert.ToInt32(textBox_qty.Text);
            DataGridViewRow addRow = new DataGridViewRow();
            addRow.CreateCells(dataGridView_order);
            addRow.Cells[0].Value = ++n;
            addRow.Cells[1].Value = textBox_name.Text;
            addRow.Cells[2].Value = textBox_price.Text;
            addRow.Cells[3].Value = textBox_qty.Text;
            addRow.Cells[4].Value = Total;
            dataGridView_order.Rows.Add(addRow);
            total += Total;

        }
    }
}
