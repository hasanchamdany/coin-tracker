using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            try
            {
                
                NpgsqlConnection conn = new Connection().GetConnection();
                conn.Open();

                string sql = @"select * from transaction_insert(:_transaction_type, :_wallet_name, :_category_name, :_date_tr, :_amount)";
                /*string sql = "insert into tb_transaction values (@transaction_type, @wallet_name, @category_name, @date_tr, @amount)";*/

                try
                {
                    cmd = new NpgsqlCommand(sql, conn);

                    cmd.Parameters.Add("_transaction_type", NpgsqlDbType.Varchar).Value =  newTransaction.TransactionType;
                    cmd.Parameters.Add("_wallet_name", NpgsqlDbType.Varchar).Value =  newTransaction.WalletName;
                    cmd.Parameters.Add("_category_name", NpgsqlDbType.Varchar).Value =  newTransaction.CategoryName;
                    cmd.Parameters.Add("_date_tr", NpgsqlDbType.Varchar).Value =  newTransaction.DateTr;
                    cmd.Parameters.Add("_amount", NpgsqlDbType.Integer).Value =  newTransaction.Amount;


                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Transaksi berhasil ditambahkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void UpdateTransaction(Transaction newTransaction, string id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string sql = @"select * from transaction_update(:_id, :_transaction_type, :_wallet_name, :_category_name, :_date_tr, :_amount)";

            cmd = new NpgsqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("_id", id);
            cmd.Parameters.AddWithValue("_transaction_type", newTransaction.TransactionType);
            cmd.Parameters.AddWithValue("_wallet_name", newTransaction.WalletName);
            cmd.Parameters.AddWithValue("_category_name", newTransaction);
            cmd.Parameters.AddWithValue("_date_tr", newTransaction.DateTr);
            cmd.Parameters.AddWithValue("_amount", newTransaction.Amount);

            try
            {
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data transaksi Berhasil diubah", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void DeleteTransaction(string id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
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

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       /* public List<Transaction> GetTransactions()
        {
            List<Transaction> ListTransaction = new List<Transaction>();
            try
            {
                return ListTransaction;
            }
            catch (Exception)
            {

                throw;
            }
        }*/
    }
}
