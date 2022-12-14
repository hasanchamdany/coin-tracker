using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Collections;
using NpgsqlTypes;

namespace GoCoin_WinFormFix.Entity
{
    internal class Wallet
    {
        // properties
        protected string _id;
        protected string _name;

        public string Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //constructor
        public Wallet() { }
        public Wallet(string wallet_name)
        {
            _name = wallet_name;
        }
        public Wallet(string id, string wallet_name)
        {
            _id = id;
            _name = wallet_name;
        }

        // Connection variables
        private static NpgsqlCommand cmd;
        private static NpgsqlDataReader rd;

        // methods
        public static DataTable dt;
        private string sql = null;
        private DataGridViewRow r;

        public void AddWallet(Wallet newWallet)
        {

            try
            {
                NpgsqlConnection conn = new Connection().GetConnection();
                conn.Open();

                string sql = @"select * from wallet_insert(:_wallet_name, :_amount)";
                string check = "select * from tb_wallet where wallet_name='" + newWallet.Name + "'";

                NpgsqlCommand checking = new NpgsqlCommand(check, conn);
                checking.ExecuteNonQuery();
                rd = checking.ExecuteReader();

                if (rd.HasRows && rd.Read() && rd[1].ToString() == newWallet.Name)
                {
                    MessageBox.Show("Wallet name { '" + newWallet.Name + "' } already exist!");
                    rd.Close();
                }

                else
                {
                    rd.Close();
                    try {
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("_wallet_name", newWallet.Name);
                        cmd.Parameters.AddWithValue("_amount", 0);

                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Wallet berhasil ditambahkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void UpdateWallet(Wallet wallet, string id)
        {
            string old_wallet_name = GetSpesificWallet(id);

            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string sql = @"select * from wallet_update(:_id, :_wallet_name)";

            cmd = new NpgsqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("_wallet_name", NpgsqlDbType.Varchar).Value = wallet.Name;
            cmd.Parameters.Add("_id", NpgsqlDbType.Varchar).Value = id;

            try
            {
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Wallet Berhasil diubah", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            UpdateTransactionWallet(old_wallet_name, wallet.Name);

            
        }

        public static void DeleteWallet(string id, string wallet_name)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string sql = @"select * from wallet_delete(:_id)";

            cmd = new NpgsqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("_id", id);

            try
            {
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Wallet Berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DeleteTransactionWallet(wallet_name);
        }

        private static void DeleteTransactionWallet(string wallet_name)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string sql = @"select * from transaction_delete_wallet(:_wallet_name)";

            cmd = new NpgsqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("_wallet_name", wallet_name);

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


        public static string GetSpesificWallet(string id)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string sql = "select wallet_name from tb_wallet where id = '" + id + "'";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rd = cmd.ExecuteReader();
            string wallet_name = "";
            while (rd.Read())
            {
                wallet_name = rd["wallet_name"].ToString();
            }

            conn.Close();

            return wallet_name;
        }

        public static void UpdateTransactionWallet(string old_wallet_name, string new_wallet_name)
        {
            NpgsqlConnection conn = new Connection().GetConnection();
            conn.Open();

            string sql = @"select * from transaction_update_wallet(:_old_wallet_name, :_new_wallet_name)";

            cmd = new NpgsqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("_old_wallet_name", NpgsqlDbType.Varchar).Value = old_wallet_name;
            cmd.Parameters.Add("_new_wallet_name", NpgsqlDbType.Varchar).Value = new_wallet_name;

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
    }
}
