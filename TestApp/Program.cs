using System;
using pkhmelyov.PostgresUriToConnectionString;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "postgres://postgres:1@localhost:5432/TestDatabase";
            Console.WriteLine(uri.ToPostgresConnectionString());
        }
    }
}
