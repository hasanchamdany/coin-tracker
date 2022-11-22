using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace GoCoin_WinFormFix.Entity
{
    internal class Transaction
    {
        // properties
        protected string _id;
        protected string _transaction_type;
        protected string _wallet_name;
        protected string _category_name;
        protected int _amount;
        protected string _date;

        public string Id
        {
            get { return _id; }
        }

        public string TransactionType
        {
            get { return _transaction_type; }
            set { _transaction_type = value; }
        }

        public string WalletName
        {
            get { return _wallet_name; }
            set { _wallet_name = value; }
        }

        public string CategoryName
        {
            get { return _category_name; }
            set{_category_name = value;}
        }
        public int Amount
        {
            get { return _amount; }
            set{_amount = value;}   
        }

        public string DateTr
        {
            get { return _date; }
            set{_date = value;}       
        }

        //constructor
        public Transaction() { }
        public Transaction(string transaction_type, string wallet_name, string category_name, int amount, string date)
        {
            _transaction_type = transaction_type;
            _wallet_name = wallet_name;
            _category_name = category_name;
            _amount = amount;
            _date = date;
        }
        public Transaction(string id, string transaction_type, string wallet_name, string category_name, int amount, string date)
        {
            _id = id;
            _transaction_type = transaction_type;
            _wallet_name = wallet_name;
            _category_name = category_name;
            _amount = amount;
            _date = date;
        }

        // Connection variables
        private static NpgsqlCommand cmd;
        private static NpgsqlDataReader rd;
        


        // methods
        public void AddTransaction(Transaction newTransaction)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            int totalAmount = 0;

            try
            {   
                conn.Open();
                // add transaction
                string sql = @"select * from transaction_insert(:_transaction_type, :_wallet_name, :_category_name, :_date_tr, :_amount)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add("_transaction_type", NpgsqlDbType.Varchar).Value = newTransaction.TransactionType;
                cmd.Parameters.Add("_wallet_name", NpgsqlDbType.Varchar).Value = newTransaction.WalletName;
                cmd.Parameters.Add("_category_name", NpgsqlDbType.Varchar).Value = newTransaction.CategoryName;
                cmd.Parameters.Add("_date_tr", NpgsqlDbType.Varchar).Value = newTransaction.DateTr;
                cmd.Parameters.Add("_amount", NpgsqlDbType.Integer).Value = newTransaction.Amount;

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Transaksi berhasil ditambahkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }


            // Get total amount
            totalAmount = GetTotalAmount(newTransaction.WalletName);

            // Update wallet amount
            UpdateWalletAmount(newTransaction.WalletName, totalAmount);
          
        }


        public static void UpdateTransaction(Transaction newTransaction, string id, string transaction_type, string wallet_name, string category, int amount, string date_tr)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            string sql = @"select * from transaction_update(:_id, :_transaction_type, :_wallet_name, :_category_name, :_date_tr, :_amount)";
            int totalAmount = 0;

            try
            {
                conn.Open();
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add("_id", NpgsqlDbType.Varchar).Value = newTransaction.Id;
                cmd.Parameters.Add("_transaction_type", NpgsqlDbType.Varchar).Value = newTransaction.TransactionType;
                cmd.Parameters.Add("_wallet_name", NpgsqlDbType.Varchar).Value = newTransaction.WalletName;
                cmd.Parameters.Add("_category_name", NpgsqlDbType.Varchar).Value = newTransaction.CategoryName;
                cmd.Parameters.Add("_date_tr", NpgsqlDbType.Varchar).Value = newTransaction.DateTr;
                cmd.Parameters.Add("_amount", NpgsqlDbType.Integer).Value = newTransaction.Amount;


                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data transaksi Berhasil diubah", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            // Get total amount
            totalAmount = GetTotalAmount(wallet_name);

            // Update wallet amount
            UpdateWalletAmount(wallet_name, totalAmount);
           
        }


        public static void DeleteTransaction(string id, string wallet_name)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            int totalAmount = 0;

            try
            {
                conn.Open();
                string query = @"select * from transaction_delete(:_id)";

                cmd = new NpgsqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("_id", id);

                try
                {
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data transaksi Berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            // Get total amount
            totalAmount = GetTotalAmount(wallet_name);

            // Update wallet amount
            UpdateWalletAmount(wallet_name, totalAmount);
        }


        public static void UpdateWalletAmount(string _wallet_name, int _total_amount)
        {
            // update amount in table wallet
            NpgsqlConnection conn = new Connection().GetConnection();

            conn.Open();
            string sqlUpdateWallet = @"select * from wallet_update_amount(:_amount, :_wallet_name)";

            cmd = new NpgsqlCommand(sqlUpdateWallet, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("_wallet_name", NpgsqlDbType.Varchar).Value = _wallet_name;
            cmd.Parameters.Add("_amount", NpgsqlDbType.Integer).Value = _total_amount;

            try
            {
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public static int GetTotalAmount(string wallet_name)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            int income = 0;
            int outcome = 0;
            int totalAmount = 0;


            // Get Income
            try
            {
                string sqlGetIncome = "select sum(amount) as Amount from tb_transaction " +
                    "where wallet_name = '" + wallet_name + "' " +
                    "and transaction_type = 'Income'";

                conn.Open();
                cmd = new NpgsqlCommand(sqlGetIncome, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    income = int.Parse(rd["amount"].ToString());
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
            }


            // Get Outcome
            try
            {
                string sqlGetOutcome = "select sum(amount) as Amount from tb_transaction " +
                    "where wallet_name = '" + wallet_name + "' " +
                    "and transaction_type = 'Outcome'";

                conn.Open();
                cmd = new NpgsqlCommand(sqlGetOutcome, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    outcome = int.Parse(rd["amount"].ToString());
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
            }


            // Get total amount
            totalAmount = income - outcome;

            return totalAmount;
        }

    }
}
