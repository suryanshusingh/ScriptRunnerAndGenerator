using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace spforcoretrac.DataObjects
{
    class DOLocationInfo
    {

        static string AppServerName = DOAppDatabaseInfo.ServerName;
        static string AppUserId = DOAppDatabaseInfo.UserID;
        static string AppPassword = DOAppDatabaseInfo.Password;
        static string AppDBName = DOAppDatabaseInfo.DatabaseName;
        static string ConnectionString = $"Data Source={AppServerName};User ID={AppUserId};Password={AppPassword};Initial Catalog={AppDBName};";


        public static string GetFolderLocation(string LocationofRunOrGenerate)
        {
            string TableName = "Run_Script_Location_Info";

            if (LocationofRunOrGenerate == "generatescript")
            {
                TableName = "Generate_Script_Location_Info";
            }


            string getstring = $"SELECT * FROM [{AppDBName}].[dbo].[{TableName}]";
            string location = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand getcommand = new SqlCommand(getstring, connection))
                    {
                         location = (string)getcommand.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return location;
        }

        public static bool UpdateFolderLocation(string location, string LocationofRunOrGenerate)
        {
            string TableName = "Run_Script_Location_Info";

            if (LocationofRunOrGenerate == "generatescript")
            {
                TableName = "Generate_Script_Location_Info";
            }

            string updatestring = $"UPDATE [{AppDBName}].[dbo].[{TableName}] SET Location = '{location}';" ;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand updatecommand = new SqlCommand(updatestring, connection))
                    {
                        updatecommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
