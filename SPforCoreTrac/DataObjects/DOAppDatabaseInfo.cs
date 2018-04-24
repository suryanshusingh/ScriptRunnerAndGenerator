using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace spforcoretrac.DataObjects
{
    public class DOAppDatabaseInfo
    {
        public static string ServerName
        {
            get;
            private set;
        }
        public static string UserID
        {
            get;
            private set;
        }
        public static string Password
        {
            get;
            private set;
        }
        public static string DatabaseName
        {
            get;
            private set;
        } = "CT_Tool";


        public static bool GetDBInfoFromFile()
        {
            int count = 0;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CTTool\\CT_Tool.xml";

            XmlDocument file = new XmlDocument();
            file.Load(path);
            foreach (XmlNode node in file.DocumentElement.ChildNodes)
            {
                switch(node.Name)
                {
                    case "Server_Name":
                        ServerName = node.InnerText;
                        break;

                    case "User_ID":
                        UserID = node.InnerText;
                        break;

                    case "Password":
                        Password = node.InnerText;
                        break;       
                }
                count++;
            }
            if (count==3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
