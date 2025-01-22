using System;
using System.Collections;
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
    public partial class CategoryForm : Form
    {
        DbConnect dbCon = new DbConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void SelectTable()
        {
            SqlCommand com = new SqlCommand("SelectCategory", dbCon.GetCon());
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_category.DataSource = dt;

            com.Dispose();
            adapter.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + textBox_id.Text + ", '" + textBox_name.Text + "')";
                SqlCommand com = new SqlCommand(insertQuery, dbCon.GetCon());
                dbCon.OpenCon();

                com.ExecuteNonQuery();
                MessageBox.Show("Category Added");
                dbCon.CloseCon();

                com.Dispose();
                SelectTable();


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            SelectTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE Category SET CategoryName='" + textBox_name.Text + "' WHERE CategoryId=" + textBox_id.Text + "";
                SqlCommand com = new SqlCommand(updateQuery, dbCon.GetCon());
                dbCon.OpenCon();

                com.ExecuteNonQuery();
                MessageBox.Show("Category Updated");
                dbCon.CloseCon();

                com.Dispose();

                SelectTable();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Category WHERE CategoryId="+textBox_id.Text+"";
                SqlCommand com = new SqlCommand(deleteQuery, dbCon.GetCon());
                dbCon.OpenCon();

                com.ExecuteNonQuery();
                MessageBox.Show("Category Deleted");
                dbCon.CloseCon();

                com.Dispose();

                SelectTable();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void label_exit_MouseEnter_1(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave_1(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductsForm prd = new ProductsForm();
            prd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }
    }
}
