using System;

namespace CSharpIntermediate.Models
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening connection to SQL Server...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing connection to SQL Server...");
        }
    }
}