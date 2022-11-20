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
    public partial class FormStatistic : Form
    {
        NpgsqlConnection conn = new Connection().GetConnection();
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        Transaction newTrans;

        public FormStatistic()
        {
            InitializeComponent();
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            LoadIncomeChart();
            LoadOutcomeChart();
        }

        private void LoadIncomeChart()
        {
            try
            {
                conn.Open();

                chIncome.DataSource = null;
                sql = "select (category_name) as Category, sum(amount) as Amount from tb_transaction where transaction_type = 'Income' group by (category_name) ";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                chIncome.DataSource = dt;


                chIncome.Series["Income"].XValueMember = "Category";
                chIncome.Series["Income"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chIncome.Series["Income"].YValueMembers = "Amount";
                chIncome.Series["Income"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOutcomeChart()
        {
            try
            {
                conn.Open();

                chOutcome.DataSource = null;
                sql = "select (category_name) as Category, sum(amount) as Amount from tb_transaction where transaction_type = 'Outcome' group by (category_name) ";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                chOutcome.DataSource = dt;

                chOutcome.Series["Outcome"].XValueMember = "Category";
                chOutcome.Series["Outcome"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chOutcome.Series["Outcome"].YValueMembers = "Amount";
                chOutcome.Series["Outcome"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
