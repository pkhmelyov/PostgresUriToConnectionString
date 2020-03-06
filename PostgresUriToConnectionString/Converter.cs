using System;
using Npgsql;

namespace pkhmelyov.PostgresUriToConnectionString
{
    public static class StringExtensions
    {
        public static string ToPostgresConnectionString(this string uriString)
        {
            Uri databaseUri = new Uri(uriString);
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
            builder.Username = databaseUri.UserInfo.Split(':')[0];
            builder.Password = databaseUri.UserInfo.Split(':')[1];
            builder.Host = databaseUri.Host;
            builder.Port = databaseUri.Port;
            builder.Database = databaseUri.AbsolutePath.Trim('/');
            builder.SslMode = SslMode.Prefer;
            builder.TrustServerCertificate = true;
            return builder.ConnectionString;
        }
    }
}
