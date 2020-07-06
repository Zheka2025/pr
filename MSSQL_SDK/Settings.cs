using System;
using System.Data.SqlClient;
namespace MSSQL_SDK
{
    class Settings
    {
        public static string hostname { get; private set; }
        public static string username { get; private set; }
        public static string password { get; private set; }
        public static string database { get; private set; }
        public static string connectionString { get; private set; }
        private SqlConnectionStringBuilder builder { get; set; }

        public Settings(string h, string u, string p, string d)
        {
            builder = new SqlConnectionStringBuilder();
            builder.DataSource = hostname = h;
            builder.UserID = username = u;
            builder.Password = password = p;
            builder.InitialCatalog = database = d;
        }

        public void SetConnTimeOut(int time) => builder.ConnectTimeout = time;

        public void SetEncrypt(bool s) => builder.Encrypt = s;

        public string getString()
        {
            connectionString = builder.ConnectionString;
            return connectionString;
        }
    }
}
