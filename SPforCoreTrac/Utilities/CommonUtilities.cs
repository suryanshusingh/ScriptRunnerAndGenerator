using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace spforcoretrac
{
    class CommonUtilities
    {
        public static bool ConfigFileExists()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path += "\\CTTool\\CT_Tool.xml";

            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ErrorMessage(string error)
        {
            MessageBox.Show(error, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SuccessMessage(string success)
        {
            MessageBox.Show(success, "Success Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
