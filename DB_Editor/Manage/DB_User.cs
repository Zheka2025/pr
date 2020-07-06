using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.Manage
{
    class DB_User
    {
        public static string username { get; set; }
        public static string current_db { get; set; }
        public static bool isAuthed { get; set; }
    }
}
