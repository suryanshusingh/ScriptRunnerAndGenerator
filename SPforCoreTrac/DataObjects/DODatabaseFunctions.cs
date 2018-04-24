using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using spforcoretrac.Utilities;

namespace spforcoretrac.DataObjects
{
    class DODatabaseFunctions
    {

        string AppServerName = DOAppDatabaseInfo.ServerName;
        string AppUserId = DOAppDatabaseInfo.UserID;
        string AppPassword = DOAppDatabaseInfo.Password;
        string AppDBName = DOAppDatabaseInfo.DatabaseName;

        public List<DatabaseInfoList> GetDatabaseInfo()
        {
            List<DatabaseInfoList> databaseitems = new List<DatabaseInfoList>();

            string ConnectionString = $"Data Source={AppServerName};User ID={AppUserId};Password={AppPassword};Initial Catalog={AppDBName};";

            string getstring = $"SELECT * FROM [{AppDBName}].[dbo].[Run_Script_Database_Info]";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand getcommand = new SqlCommand(getstring, connection))
                    {
                        SqlDataReader data = getcommand.ExecuteReader();

                        if (data != null)
                            while (data.Read())
                            {
                                DatabaseInfoList row = new DatabaseInfoList();
                                row.ID = (int)data["ID"];
                                row.UniqueName = (string)data["UniqueName"];
                                row.ServerName = (string)data["ServerName"];
                                row.UserName = (string)data["UserName"];
                                row.Password = (string)data["Password"];
                                row.DatabaseName = (string)data["DatabaseName"];
                                databaseitems.Add(row);
                            }
                        
                        if (data != null)
                        {
                            data.Dispose();
                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return databaseitems;
        }
        public bool InsertDatabaseInfo(string viewname, string servername, string userid, string password, string databasename, out string errormessage)
        {
            string ConnectionString = $"Data Source={AppServerName};User ID={AppUserId};Password={AppPassword};Initial Catalog={AppDBName};";

            string Message = null;

            int id = GetNewID();

            if (id == 0)
            {
                errormessage = "Cannot get the id number";
                return false;
            }

            string insertdbinfo = $"INSERT INTO [{AppDBName}].[DBO].[Run_Script_Database_Info] (ID, UniqueName, ServerName, UserName, Password, DatabaseName)" +
                                $"VALUES ('{id}','{viewname}','{servername}','{userid}','{password}','{databasename}')";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand commanddbcreate = new SqlCommand(insertdbinfo, connection))
                    {
                        commanddbcreate.ExecuteNonQuery();
                        Message = "Information Added Successfully";
                    }
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
            errormessage = Message;
            return true;
        }

        public bool DeleteDatabaseInfo()
        {
            return true;
        }

        public bool UpdataDatabaseInfo()
        {
            return true;
        }

        private int GetNewID()
        {
            string ConnectionString = $"Data Source={AppServerName};User ID={AppUserId};Password={AppPassword};Initial Catalog={AppDBName};";
            int id = 0;
            string getidcommand = $"SELECT [ID] FROM [{AppDBName}].[DBO].[Run_Script_Database_Info] ORDER BY ID DESC;";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand idcommand = new SqlCommand(getidcommand, connection))
                    {
                        id = Convert.ToInt16(idcommand.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return ++id;
        }
    }
}
