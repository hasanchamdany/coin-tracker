using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCoin_WinForm.Entity
{
    class Wallet
    {
        // properties
        public int Id { get; set; }
        public string Wallet_name { get; set; }

        //constructor
        public Wallet() { }
        public Wallet(int id, string wallet_name)
        {
            Id = id;
            Wallet_name = wallet_name;
        }
    }
}
