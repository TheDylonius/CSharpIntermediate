using System;

namespace CSharpIntermediate.Models
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening connection to Oracle Server...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing connection to Oracle Server...");
        }
    }
}