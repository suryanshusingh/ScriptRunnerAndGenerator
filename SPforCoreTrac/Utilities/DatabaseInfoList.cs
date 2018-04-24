using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spforcoretrac.Utilities
{
    public class DatabaseInfoList
    {
        public int ID{get; set;}
        public string UniqueName { get; set; }

        public string ServerName { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string DatabaseName { get; set; }
    }
}
