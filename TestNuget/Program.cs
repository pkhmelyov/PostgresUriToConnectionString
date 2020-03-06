using System;
using pkhmelyov.PostgresUriToConnectionString;

namespace TestNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "postgres://postgres:1@localhost:5432/TestDatabase";
            Console.WriteLine(uri.ToPostgresConnectionString());
        }
    }
}
