using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCoin_WinFormFix.Entity
{
    internal class Transaction
    {
        // properties
        public int id { get; set; }
        public string transaction_type { get; set; }
        public string wallet_name { get; set; }
        public string category_name { get; set; }
        public int amount { get; set; }
        public string date { get; set; }

        //constructor
        public Transaction() { }
        public Transaction(int _id, string _transaction_type, string _wallet_name, string _category_name, int _amount, string _date)
        {
            id = id;
            transaction_type = _transaction_type;
            wallet_name = _wallet_name;
            category_name = _category_name;
            amount = _amount;
            date = _date;
        }

        // methods
        public void AddTransaction() { }
        public void RemoveTransaction() { }
        public void UpdateTransaction() { }
        public List<Transaction> GetTransactions()
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
        }
    }
}
