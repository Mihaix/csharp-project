using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Baze_de_Date
{
    public partial class Dashboard : Form
    {
        private int userId;
        private LoginForm initialLoginForm;
        public Dashboard(LoginForm loginForm, int userId)
        {
            InitializeComponent();

            this.initialLoginForm = loginForm;
            this.userId = userId;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'facturiInfoDataSet.FacturiData' table. You can move, or remove it, as needed.
            this.facturiDataTableAdapter.Fill(this.facturiInfoDataSet.FacturiData, userId);

        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            string factura = textFac.Text;
            string suma = textSum.Text;
            string scad = textSca.Text;

            facturiDataTableAdapter.AdaugaFactura(userId, factura, suma, scad);
            this.facturiDataTableAdapter.Fill(this.facturiInfoDataSet.FacturiData, userId);
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.initialLoginForm.Show();
        }
    }
}
