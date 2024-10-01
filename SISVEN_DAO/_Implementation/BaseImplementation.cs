using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using Mysqlx.Connection;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Policy;


namespace SISVEN_DAO._Implementation
{
    public class BaseImplementation
    {
        string connectionString = "Server=localhost;Database=bdventa;Uid=root;Pwd=;";
        public string query;

        public MySqlCommand CreateBasicCommand() {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand comand = new MySqlCommand();
            comand.Connection = connection;
            return comand;
        }

        public MySqlCommand CreateBasicCommand(string query) {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand comand = new MySqlCommand(query, connection);
            return comand;
        }

        /// <summary>
        /// INSERT, UPDATE or DELETE
        /// </summary>
        /// <param name="comand">Comando asiciado a una conexion y con su SQL query</param>
        /// <returns></returns>
        public int ExecuteBasic(MySqlCommand comand) {
            int n = 0;
            try
            {
                comand.Connection.Open();
                n=comand.ExecuteNonQuery();
                return n;
            }
            catch (Exception ex)
            {
                throw ex;  //trabajemos con la exepcion en donde lo lancemos
            }
            finally
            {
                comand.Connection.Close();
            }
            return n;
        }

        /// <summary>
        /// SELECT
        /// </summary>
        /// <param name="comand">Comando asociado a una conexion con SQL query</param>
        /// <returns></returns>
        public DataTable ExecuteDataTableCommand(MySqlCommand comand) {
            DataTable table = new DataTable();
            try
            {
                comand.Connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comand);
                adapter.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                comand.Connection.Close();
            }
            return table;
        }
    }
}
