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

        public NpgsqlConnection conn;
        /*public string connstring = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=GoCoin";*/
        string connstring = "Host = localhost; port=5432; username = postgres; password = admin; database = GoCoin";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            /*loadWallet();*/
        }

        /*private void loadWallet()
        {
            try
            {
                conn.Open();
                sql = "select wallet_name from tb_wallet";
                cmd = new NpgsqlCommand(sql, conn);
                List<string> cbWalletData = new List<string>();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Object data = new object();
                    cbWalletData.Add(data.ToString());
                }
                cbWallet.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void btnEditWallet_Click(object sender, EventArgs e)
        {

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
    }
}
