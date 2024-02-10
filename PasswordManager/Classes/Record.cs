using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Classes
{
    internal class Record
    {
        public int id { get; set; }
        public int userid { get; set; }
        public string url { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string note { get; set; }
    }
}
