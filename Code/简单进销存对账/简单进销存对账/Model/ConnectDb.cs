using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 简单进销存对账.Model
{
    internal class ConnectDb
    {
        internal OleDbConnection connection;
        public ConnectDb()
        {
            String strConnect = @"Provider=Microsoft.Jet.OLEDB.4.0;Data source=./db/Database.mdb;";
            this.connection = new OleDbConnection(strConnect);
            this.connection.Open();
        }

        public void close()
        {
            this.connection.Close();
        }
    }
}
