using ComponentFactory.Krypton.Toolkit;
using GoCoin_WinFormFix.Entity;
using Npgsql;
using System;
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
    public partial class FormDashboard : Form
    {
        NpgsqlConnection conn = new Connection().GetConnection();
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        Transaction newTrans;
        DateTime dateNow = DateTime.Now;

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            loadCBWallet();
            loadDgvIncome();
            loadDgvOutcome();
        }

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            try
            {
                string transaction_type = "";
                string category = cbCategory.Text;
                string wallet_name = cbWallet.Text;
                string date_tr = dateNow.ToString();
                int amount = int.Parse(txtAmount.Text);

                if (rdbIncome.Checked)
                {
                    transaction_type = rdbIncome.Text;
                }
                else if (rdbOutcome.Checked)
                {
                    transaction_type = rdbOutcome.Text;
                }

                newTrans = new Transaction(transaction_type, wallet_name, category, amount, date_tr);
                newTrans.AddTransaction(newTrans);

                loadDgvIncome();
                loadDgvOutcome();
                resetInput();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditTrans_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan di edit", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string id = r.Cells["id"].Value.ToString();
                string transaction_type = "";
                string category = cbCategory.Text;
                string wallet_name = cbWallet.Text;
                string date_tr = dateNow.ToString();
                int amount = int.Parse(txtAmount.Text);

                if (rdbIncome.Checked)
                {
                    transaction_type = rdbIncome.Text;
                }
                else if (rdbOutcome.Checked)
                {
                    transaction_type = rdbOutcome.Text;
                }

                newTrans = new Transaction(id, transaction_type, wallet_name, category, amount, date_tr);
                Transaction.UpdateTransaction(newTrans, id, transaction_type, wallet_name, category, amount, date_tr);

                conn.Close();

                loadDgvIncome();
                loadDgvOutcome();
                resetInput();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Update Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTrans_Click(object sender, EventArgs e)
        {

            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan di dihapus", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["id"].Value.ToString() + " ?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    string id = r.Cells["id"].Value.ToString();
                    Transaction.DeleteTransaction(id);

                    conn.Close();

                    loadDgvIncome();
                    loadDgvOutcome();
                    resetInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Delete Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void loadDgvIncome()
        {
            try
            {
                conn.Open();

                dgvIncome.DataSource = null;
                sql = "select * from tb_transaction where transaction_type = 'Income' ";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvIncome.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadDgvOutcome()
        {
            try
            {
                conn.Open();

                dgvOutcome.DataSource = null;
                sql = "select * from tb_transaction where transaction_type = 'Outcome' ";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvOutcome.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        private void loadCBWallet()
        {
            try
            {
                conn.Open();
                cbWallet.DataSource = null;
                sql = "select wallet_name from tb_wallet";
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();                

                List<string> cbWalletData = new List<string>();
                while (rd.Read())
                {
                    string walletName = rd["wallet_name"].ToString();
                    cbWalletData.Add(walletName);
                }

                cbWallet.DataSource = cbWalletData;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbIncome_CheckedChanged(object sender, EventArgs e)
        {
            List<string> cbCategoryData = new List<string>();
            cbCategoryData.Add("Sallary");
            cbCategoryData.Add("Bonus");
            cbCategory.DataSource = cbCategoryData;
        }

        private void rdbOutcome_CheckedChanged(object sender, EventArgs e)
        {
            List<string> cbCategoryData = new List<string>();
            cbCategoryData.Add("Food");
            cbCategoryData.Add("Entertainment");
            cbCategory.DataSource = cbCategoryData;
        }

        private void resetInput()
        {
            rdbOutcome.Checked = false;
            rdbIncome.Checked = false;
            cbWallet.Text = null;
            cbCategory.Text = null;
            txtAmount.Text = null;
        }

        private void dgvIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvIncome.Rows[e.RowIndex];
                string trans_type = r.Cells["transaction_type"].Value.ToString();
                if (trans_type == "Income") {
                    rdbIncome.Checked = true;
                }
                else
                {
                    rdbOutcome.Checked = true;
                }
                cbCategory.Text = r.Cells["category_name"].Value.ToString();
                cbWallet.Text = r.Cells["wallet_name"].Value.ToString();
                txtAmount.Text = r.Cells["amount"].Value.ToString();
            }
        }
        

        private void dgvOutcome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvOutcome.Rows[e.RowIndex];
                string trans_type = r.Cells["transaction_type"].Value.ToString();
                if (trans_type == "Income")
                {
                    rdbIncome.Checked = true;
                }
                else
                {
                    rdbOutcome.Checked = true;
                }
                cbCategory.Text = r.Cells["category_name"].Value.ToString();
                cbWallet.Text = r.Cells["wallet_name"].Value.ToString();
                txtAmount.Text = r.Cells["amount"].Value.ToString();
            }
        }
    }
}
