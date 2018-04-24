using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace spforcoretrac.DataObjects
{
    class DOFileCreateAndUpdate
    {
        public static bool CreateAndUpdateFile(string servername, string userid, string password)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CTTool";

            string filename = "CT_Tool.xml";

            Directory.CreateDirectory(path);

            string fullpath = Path.Combine(path, filename);

            XmlTextWriter ctxmlfile = null;
            try
            {
                ctxmlfile  = new XmlTextWriter(fullpath, System.Text.Encoding.UTF8);
                ctxmlfile.Formatting = Formatting.Indented;
                ctxmlfile.WriteStartElement("CT_Tool_Metadata");
                ctxmlfile.WriteStartElement("Server_Name");
                ctxmlfile.WriteString(servername);
                ctxmlfile.WriteEndElement();
                ctxmlfile.WriteStartElement("User_ID");
                ctxmlfile.WriteString(userid);
                ctxmlfile.WriteEndElement();
                ctxmlfile.WriteStartElement("Password");
                ctxmlfile.WriteString(password);
                ctxmlfile.WriteEndElement();
                ctxmlfile.WriteEndElement();
            }
            catch(Exception)
            {
                return false;
            }
            
            finally
            {
                ctxmlfile.Close();
            }
            return true;
        }
    }
}
