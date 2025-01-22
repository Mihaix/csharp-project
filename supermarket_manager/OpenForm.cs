using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket_manager
{
    public partial class OpenForm : Form
    {
        public OpenForm()
        {
            InitializeComponent();
        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 4;
            
            progressBar1.Value = startPoint;

            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();

                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

        private void OpenForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
