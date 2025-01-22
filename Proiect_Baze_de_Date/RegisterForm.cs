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

namespace Proiect_Baze_de_Date
{
    public partial class registerForm : Form
    {

        public registerForm()
        {
            InitializeComponent();
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihai\OneDrive\Desktop\Proiect Baze de Date\LoginInfo.mdf;Integrated Security=True");
            SqlCommand cmd;

            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Please enter an Username and Password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                cn.Open();
                string register1 = "INSERT INTO LoginData VALUES ('"+txtUsername.Text+ "', '"+txtPassword.Text+"')";
                cmd = new SqlCommand(register1, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your Account has been Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password does not match", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new LoginForm(this).Show();
            this.Hide();
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }
    }
}

// DBCC CHECKIDENT('LoginData', RESEED, 0);













