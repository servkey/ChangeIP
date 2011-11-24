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

        //@"Data Source=.\Setting\settings.s3db";
        public DBLiteConnection(string strConnection)
        {
            this.strConnection = strConnection;
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

        public SQLiteDataReader ExecuteQuery(string query)
        {
            SQLiteConnection con = new SQLiteConnection(strConnection);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader datos = cmd.ExecuteReader();
            // Leemos los datos de forma repetitiva
            /*while (datos.Read())
            {
                string codigo = Convert.ToString(datos[0]);
                string nombre = Convert.ToString(datos[1]);
                // Y los mostramos
                Console.WriteLine("Codigo: {0}, Nombre: {1}",
                    codigo, nombre);
            }*/
            return datos;
        }
    
    }
}
