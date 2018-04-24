using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using spforcoretrac.Utilities;
using System.Data.SqlClient;
using System.IO;

namespace spforcoretrac.DataObjects
{
    class DOScriptRun
    {
        public List<int> CheckPreviouslyRunScripts(DatabaseInfoList DBInfo)
        {
            List<int> alreadyrunscripts = new List<int>();

            string ConnectionString = $"Data Source={DBInfo.ServerName};User ID={DBInfo.UserName};Password={DBInfo.Password};Initial Catalog={DBInfo.DatabaseName};";

            string getstring = $"SELECT DISTINCT Version FROM [{DBInfo.DatabaseName}].[dbo].[DatabaseUpgrades] WHERE Success='1' ORDER BY VERSION;";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand getcommand = new SqlCommand(getstring, connection))
                    {
                        SqlDataReader data = getcommand.ExecuteReader();

                        if (data != null)
                        {
                            while (data.Read())
                            {
                                alreadyrunscripts.Add((int)data["Version"]);
                            }
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
            return alreadyrunscripts;
        }

        public static void UpdateDatabaseInfoTable(DatabaseInfoList DBInfo)
        {
            string ConnectionString = $"Data Source={DBInfo.ServerName};User ID={DBInfo.UserName};Password={DBInfo.Password};Initial Catalog={DBInfo.DatabaseName};";

            string updatestring = $"UPDATE [{DBInfo.DatabaseName}].[dbo].[DatabaseInfo] SET Version = '0';";

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

            catch (Exception ex)
            {

            }
        }

        public void RunScripts(List<int> fileversionstorun, DatabaseInfoList DBInfo)
        {

            string ConnectionString = $"Data Source={DBInfo.ServerName};User ID={DBInfo.UserName};Password={DBInfo.Password};Initial Catalog={DBInfo.DatabaseName};";

            string location = DOLocationInfo.GetFolderLocation("runscript");

            string[] file = null;

            foreach (int fileversion in fileversionstorun)
            {
                file = Directory.GetFiles(location, "*" + fileversion.ToString() +" - "+ "*");

                string contentsoffile = File.ReadAllText(file[0]);

                var queries = contentsoffile.Split(new[] { " GO " }, StringSplitOptions.RemoveEmptyEntries);

                //split the script on "GO" commands
                string[] splitter = new string[] { "\r\nGO\r\n" };
                string[] commandTexts = contentsoffile.Split(splitter, StringSplitOptions.RemoveEmptyEntries);

                

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        foreach (string command in commandTexts)
                        {
                            using (SqlCommand scriptcommand = new SqlCommand(command, connection))
                            {
                                scriptcommand.CommandType = System.Data.CommandType.Text;
                                scriptcommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
        }
    }
}
