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
        NpgsqlConnection conn = new Connection().GetConnection();
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public FormWallet()
        {
            InitializeComponent();
        }
        
        private void FormWallet_Load(object sender, EventArgs e)
        {
            LoadWallet();
        }

        private void LoadWallet()
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

        private void ResetInput()
        {
            txtWalletName.Text = null;
            r = null;
        }

        private void btnAddWallet_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtWalletName.Text == null) || (txtWalletName.Text == ""))
                {
                    MessageBox.Show("Mohon isi semua bagian masukan", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    newWallet = new Wallet(txtWalletName.Text);
                    newWallet.AddWallet(newWallet);

                    LoadWallet();
                    ResetInput();
                }
                
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

                if ((txtWalletName.Text == null) || (txtWalletName.Text == ""))
                {
                    MessageBox.Show("Mohon isi semua bagian masukan", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string id = r.Cells["_id"].Value.ToString();
                    string name = txtWalletName.Text;
                    newWallet = new Wallet(id, name);
                    Wallet.UpdateWallet(newWallet, id);

                    LoadWallet();
                    ResetInput();
                }
            }
            catch(Exception ex)
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
                    string wallet_name = txtWalletName.Text;
                    Wallet.DeleteWallet(id, wallet_name);

                    LoadWallet();
                    ResetInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Delete Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        

        private void dgvWallet_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvWallet.Rows[e.RowIndex];
                txtWalletName.Text = r.Cells["_wallet_name"].Value.ToString();
            }
        }
    }
}
