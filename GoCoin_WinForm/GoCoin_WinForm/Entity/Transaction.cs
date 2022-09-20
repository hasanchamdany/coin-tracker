using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCoin_WinForm.Entity
{
    internal class Transaction
    {
        // properties
        public int Id { get; set; }
        public string Transaction_type { get; set; }
        public string Wallet_name { get; set; }
        public string Category_name { get; set; }
        public double Amount { get; set; }
        public string Date { get; set; }

        //constructor
        public Transaction() { }
        public Transaction(int id, string transaction_type, string wallet_name, string category_name, double amount, string date)
        {
            Id = id;
            Transaction_type = transaction_type;
            Wallet_name = wallet_name;
            Category_name = category_name;
            Amount = amount;
            Date = date;
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
