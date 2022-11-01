﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoCoin_WinFormFix.Forms
{
    public partial class FormHomePage : Form
    {
        private Form activeForm;

        public FormHomePage()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender, string title)
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
            lblTitle.Text = title;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDashboard(), sender, "Dashboard");
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormWallet(), sender, "Wallet");
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStatistic(), sender, "Statistic");
        }
    }
}
