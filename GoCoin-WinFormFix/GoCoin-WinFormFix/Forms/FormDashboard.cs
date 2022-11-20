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

        private void btnEditTrans_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteTrans_Click(object sender, EventArgs e)
        {

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
