using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Hydroponics_application
{
    public class ConnectionString
    {
        public static string connectionString()
        {
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
            builder.Host = "kiouni.db.elephantsql.com";
            builder.Port = 5432;
            builder.Database = "tzzdghro";
            builder.Username = "tzzdghro";
            builder.Password = "2QmlTkgNPJaenYWrozh36JUR8S8lqEos";
            builder.TrustServerCertificate = true;
            builder.SslMode = SslMode.Require;

            return builder.ConnectionString;
        }
    }
}
