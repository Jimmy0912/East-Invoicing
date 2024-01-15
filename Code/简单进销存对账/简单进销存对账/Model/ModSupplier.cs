using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 简单进销存对账.DB;

namespace 简单进销存对账.Model
{
    internal class ModSupplier : ConnectDb
    {
       public void insert(TbSupplier tbSupplier)
       {
            OleDbConnection conn = this.connection;
            String strInsertSQL = "Insert Into tbSupplier (name, contact, tel, address, inday, upday) VALUES(" +
                "@name, @contact, @tel, @address, now(), now())";

            using (OleDbCommand command = new OleDbCommand(strInsertSQL, conn))
            {
                command.Parameters.Add("@name",     tbSupplier.Name);
                command.Parameters.Add("@contact",  tbSupplier.Contact);
                command.Parameters.Add("@tel",      tbSupplier.Tel);
                command.Parameters.Add("@address",  tbSupplier.Address);

                int rowsAffected = command.ExecuteNonQuery();

            }

            conn.Close();
       }

        public DataTable searchSupplier()
        {
            DataTable dataTable = new DataTable();
            string sqlQuery = "SELECT * FROM tbSupplier";

            using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
            {
                //command.Parameters.AddWithValue("@SearchName", searchName);

                // 使用 OleDbDataAdapter 执行查询并将结果填充到 DataSet
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                
                adapter.Fill(dataTable);

                // 遍历 DataSet 中的结果
                /*foreach (DataRow row in dataSet.Tables["Persons"].Rows)
                {
                    Console.WriteLine($"ID: {row["ID"]}, FirstName: {row["FirstName"]}, LastName: {row["LastName"]}");
                }*/
            }
            connection.Close();

            return dataTable;
        }
    }
}
