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
    public partial class LoginForm : Form
    {
        private registerForm initialRegisterForm;
        public LoginForm(registerForm regForm)
        {
            InitializeComponent();

            this.initialRegisterForm = regForm;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihai\OneDrive\Desktop\Proiect Baze de Date\LoginInfo.mdf;Integrated Security=True");
            SqlCommand cmd;

            cn.Open();
            string login = "SELECT * FROM LoginData WHERE Username= '"+txtUsername.Text+"' AND Password='"+txtPassword.Text+"' ";
            cmd = new SqlCommand(login, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true) 
            {
                int userId = dr.GetInt32(dr.GetOrdinal("Id"));
                //MessageBox.Show("Logged in with UserId: " + userId, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Dashboard(this, userId).Show();
                this.Hide();
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Invalie Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new registerForm().Show();
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.initialRegisterForm.Show();
        }
    }
}
