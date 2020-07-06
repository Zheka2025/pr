using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_SDK
{
    public class Connection
    {
        public SqlConnection cnn { get; private set; }
        public string ConnectionString { get; private set; }
        private Settings setting { get; set; }

        public Connection(Dictionary<string, string> settings)
        {
            try
            {
                setting = new Settings(
                    settings["hostname"],
                    settings["username"],
                    settings["password"],
                    settings["database"]);
                ConnectionString = setting.getString();
            }
            catch
            {
                throw new Exception("В словаре не найдены ключ или ключи (hostname, username, password, database)");
            }
        }

        public Connection(string h, string u, string p, string d)
        {
            setting = new Settings(h, u, p, d);
            ConnectionString = setting.getString();
        }

        public Connection(string connection_string)
        {
            Dictionary<string, string> StrParse = new Dictionary<string, string>();
            string[] tmp_parse = connection_string.Split(';');

            foreach(var item in tmp_parse)
            {
                string[] tmp = item.Split('=');
                switch(tmp[0])
                {
                    case "DataSource":
                        StrParse.Add("hostname", tmp[1]);
                        break;
                    case "User ID":
                        StrParse.Add("username", tmp[1]);
                        break;
                    case "InitialCatalog":
                        StrParse.Add("database", tmp[1]);
                        break;
                    case "Password":
                        StrParse.Add("password", tmp[1]);
                        break;
                    case "Encrypt":
                        StrParse.Add("Encrypt", tmp[1]);
                        break;
                    case "ConnectionTimeout":
                        StrParse.Add("ConnectionTimeout", tmp[1]);
                        break;
                }
            }

            try
            {
                setting = new Settings(
                    StrParse["hostname"],
                    StrParse["username"],
                    StrParse["password"],
                    StrParse["database"]);
                if (StrParse.ContainsKey("Encrypt")) setting.SetEncrypt(StrParse["Encrypt"].ToLower() == "true" ? true : false);
                if (StrParse.ContainsKey("ConnectionTimeout")) setting.SetConnTimeOut(int.Parse(StrParse["ConnectionTimeout"]));
                ConnectionString = setting.getString();
            }
            catch
            {
                throw new Exception("В словаре не найдены ключ или ключи (hostname, username, password, database)");
            }
        }

        public bool MakeConnection()
        {
            cnn = new SqlConnection(ConnectionString);
            cnn.Open();

            return CheckConnection();
        }

        public bool Open()
        {
            if (CheckConnection() == true) return true;

            cnn.Open();

            return CheckConnection();
        }

        public bool Close()
        {
            if (CheckConnection() == false) return true;

            cnn.Close();

            return !CheckConnection();
        }

        private bool CheckConnection()
        {
            if (cnn.State == ConnectionState.Open) return true;
            else return false;
        }
    }
}
