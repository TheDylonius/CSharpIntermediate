using System;

namespace CSharpIntermediate.Models
{
    abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("Please provide a connection string.");

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}