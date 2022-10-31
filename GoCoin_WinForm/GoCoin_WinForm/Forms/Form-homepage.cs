using System;
using System.Windows.Forms;

namespace GoCoin_WinForm
{
    public partial class Form1 : Form
    {
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_transaction_history(), sender);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_transaction(), sender);
        }

        private void btnPocket_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_Pocket(), sender);
        }

        private void btnStatistic_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_trans_diagram(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}