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
using GoCoin_WinFormFix.Entity;
using GoCoin_WinFormFix.Forms;


namespace GoCoin_WinFormFix.Forms
{
    public partial class FormWallet : Form
    {
        Wallet newWallet;
        public FormWallet()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new Connection().GetConnection();

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void FormWallet_Load(object sender, EventArgs e)
        {
            btnLoadWallet.PerformClick();
        }

        private void btnLoadWallet_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvWallet.DataSource = null;
                sql = "select * from wallet_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvWallet.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddWallet_Click(object sender, EventArgs e)
        {
            

            try
            {
                newWallet = new Wallet(txtWalletName.Text);
                newWallet.AddWallet(newWallet);

                btnLoadWallet.PerformClick();
                txtWalletName.Text = null;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void btnEditWallet_Click(object sender, EventArgs e)
        {
            

            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan di edit", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string id = r.Cells["_id"].Value.ToString();
                string name = txtWalletName.Text;
                newWallet = new Wallet(id, name);
                Wallet.UpdateWallet(newWallet, id);

                conn.Close();
                btnLoadWallet.PerformClick();
                txtWalletName.Text = null;
                r = null;

            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Update Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnDeleteWallet_Click(object sender, EventArgs e)
        {
            

            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan di dihapus", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["_wallet_name"].Value.ToString()+" ?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    string id = r.Cells["_id"].Value.ToString();
                    Wallet.DeleteWallet(id);
                    conn.Close();
                    btnLoadWallet.PerformClick();
                    txtWalletName.Text = null;
                    r = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Delete Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvWallet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                r = dgvWallet.Rows[e.RowIndex];
                txtWalletName.Text = r.Cells["_wallet_name"].Value.ToString();
            }
        }
    }
}
