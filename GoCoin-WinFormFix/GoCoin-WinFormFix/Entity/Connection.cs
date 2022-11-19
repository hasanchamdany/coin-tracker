using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCoin_WinFormFix.Entity
{
    internal class Connection
    {
        private NpgsqlConnection _conn;
        public string connstring = "Host = localhost; port=5432; username = postgres; password = 010702; database = Gocoin";
        public NpgsqlConnection GetConnection()
        {
            this._conn = new NpgsqlConnection(this.connstring);
            return this._conn;
        }
    }
}
