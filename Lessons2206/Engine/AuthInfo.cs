using IniWorker;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2206.Engine
{
    static class AuthInfo
    {
        public static IniFile ini { get; set; } = new IniFile();
        public static string username { get; set; } = null;
        public static string password { get; set; } = null;
        public static int id { get; set; } = -1;
        public static bool useQuickAuth { get; set; } = false;
        public static bool isAuthed { get; set; } = false;

        public static bool SavePassword()
        {
            if (username == null && password == null) return false;
            ini.Write("username", username, "Auth");
            ini.Write("password", password, "Auth");
            ini.Write("useQuickAuth", useQuickAuth.ToString(), "Auth");
            return true;
        }

        public static Enums.StatusName MakeAuth()
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM accounts WHERE username = '{username}' AND pass = '{password}'");
            cmd.Connection = Program.db.cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows) return Enums.StatusName.FalseCreditional;
            while (reader.Read()) id = reader.GetInt32(0);
            reader.Close();
            SqlCommand cmd2 = new SqlCommand($"SELECT [dbo].[LastAuth] ({id})");
            cmd2.Connection = Program.db.cnn;
            SqlDataReader reader1 = cmd2.ExecuteReader();
            while (reader1.Read()) continue;
            reader1.Close();
            return Enums.StatusName.Success;
        }
    }
}
