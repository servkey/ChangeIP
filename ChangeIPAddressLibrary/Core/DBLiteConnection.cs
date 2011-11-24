using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace ChangeIPAddressLibrary.Core
{
    public class DBLiteConnection
    {
        private string strConnection;

        public DBLiteConnection()
        {
            strConnection = @"Data Source=.\Setting\settings.s3db";
        }

        public int ExecuteNonQuery(string sql)
        {
            int rows = 0;
            SQLiteConnection con = new SQLiteConnection(strConnection);
            con.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = sql;
            rows = command.ExecuteNonQuery();
            con.Close();
            return rows;
        }

    
    }
}
