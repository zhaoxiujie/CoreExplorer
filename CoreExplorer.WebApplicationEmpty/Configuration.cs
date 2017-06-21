using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreExplorer.WebApplicationEmpty
{
    public class Configuration
    {
        public DatabaseConfiguration Database { get; set; }

        public FacebookConfiguration Facebook { get; set; }

        public SmtpConfiguration Smtp { get; set; }
    }


    public class DatabaseConfiguration
    {
        public string DatabaseName { get; set; }
        public string ServerHost { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string ConnectionString => $"Server=tcp:{ServerHost},{Port};DataBase={DatabaseName};" +
            $"User ID={Username};Password={Password};" +
            $"Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }

    public class FacebookConfiguration
    {
        public string AppId { get; set; }
        public string AppSecret { get; set; }
    }

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool EnableSsl { get; set; }
        public int Port { get; set; }
    }
}
