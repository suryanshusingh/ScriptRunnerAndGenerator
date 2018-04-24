using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace spforcoretrac.DataObjects
{
    class DOTestConnection
    {
        public bool CheckConnection(string servername, string userid, string password, string dbname, out string errorMessage)
        {
            string ConnectionString = $"Data Source={servername};User ID={userid};Password={password};Initial Catalog={dbname};";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();
                        command.ExecuteScalar();
                    }
                }


            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
            finally
            {

            }
            errorMessage = "";
            return true;
        }

        public bool CheckAppServerConnection(string servername, string userid, string password, out string errormessage)
        {
            string ConnectionString = $"Data Source={servername};User ID={userid};Password={password}";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
            }

            catch (Exception ex)
            {
                errormessage = ex.Message;
                return false;
            }
            finally
            {
            }
              
            errormessage = "";
            return true;
        }
    }
}
