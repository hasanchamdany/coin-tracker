using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoCoin_WinFormFix.Forms
{
    public partial class FormWallet : Form
    {
        public FormWallet()
        {
            InitializeComponent();
        }
        public NpgsqlConnection conn;
        /*public string connstring = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=GoCoin";*/
        string connstring = "Host = localhost; port=5432; username = postgres; password = admin; database = gocoindb";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void FormWallet_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            btnLoadWallet.PerformClick();
        }

        private void btnAddWallet_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from wallet_insert(:_wallet_name)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_wallet_name", txtWalletName.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Wallet berhasil ditambahkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoadWallet.PerformClick();
                    txtWalletName.Text = null;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadWallet_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvWalletData.DataSource = null;
                sql = "select * from wallet_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvWalletData.DataSource = dt;

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvWalletData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                r = dgvWalletData.Rows[e.RowIndex];
                txtWalletName.Text = r.Cells["Walletname"].Value.ToString();
            }
        }

        private void btnEditWallet_Click(object sender, EventArgs e)
        {
            if(r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan di edit", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from wallet_update(:_id :_wallet_name)";
                cmd = new NpgsqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("_id", r.Cells("_id").Value.ToString());
                cmd.Parameters.AddWithValue("_wallet_name", txtWalletName.Text);
                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Wallet Berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoadWallet.PerformClick();
                    txtWalletName = null;
                    r = null;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Update Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
