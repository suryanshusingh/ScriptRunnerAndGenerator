using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace spforcoretrac.DataObjects
{
    class DODatabaseCreation
    {

        public bool CreateDB(string appservername, string appuserid, string apppassword, out string errorMessage)
        {
            string ConnectionString = $"Data Source={appservername};User ID={appuserid};Password={apppassword};";
            string Message = null;

            string dbcreatestr = "CREATE DATABASE CT_Tool";

            StringBuilder tablecreatestr = new StringBuilder();
            tablecreatestr.Append("USE [CT_Tool]\n");
            tablecreatestr.Append("CREATE TABLE Run_Script_Database_Info\n");
            tablecreatestr.Append("(ID int NOT NULL,");
            tablecreatestr.Append("UniqueName varchar(255) NOT NULL,\n");
            tablecreatestr.Append("ServerName varchar (255) NOT NULL,\n");
            tablecreatestr.Append("UserName varchar (255) NOT NULL,\n");
            tablecreatestr.Append("Password varchar (255) NOT NULL,\n");
            tablecreatestr.Append("DatabaseName varchar (255) NOT NULL\n");
            tablecreatestr.Append(");");
            tablecreatestr.Append("USE [CT_Tool]\n");
            tablecreatestr.Append("CREATE TABLE Run_Script_Location_Info\n");
            tablecreatestr.Append("(\n");
            tablecreatestr.Append("Location varchar(5000) NOT NULL\n");
            tablecreatestr.Append(");\n");
            tablecreatestr.Append("INSERT INTO [CT_Tool].[dbo].[Run_Script_Location_Info] VALUES ('C:\');\n");
            tablecreatestr.Append("USE [CT_Tool]\n");
            tablecreatestr.Append("CREATE TABLE Generate_Script_Location_Info\n");
            tablecreatestr.Append("(\n");
            tablecreatestr.Append("Location varchar(5000) NOT NULL\n");
            tablecreatestr.Append(");\n");
            tablecreatestr.Append("INSERT INTO [CT_Tool].[dbo].[Generate_Script_Location_Info] VALUES ('C:\');\n");


            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand commanddbcreate = new SqlCommand(dbcreatestr, connection))
                    {
                        commanddbcreate.ExecuteNonQuery();
                        Message = "Database Creation Successful";
                    }
                    
                    using (SqlCommand commanttablecreate = new SqlCommand(tablecreatestr.ToString(), connection))
                    {
                        commanttablecreate.ExecuteNonQuery();
                        Message += "Table Creation Successful";
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = Message + ex.Message;
                return false;
            }
            finally
            {

            }
            errorMessage = Message;
            return true;

        }
    }
}
