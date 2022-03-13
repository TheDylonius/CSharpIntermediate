using System;
using CSharpIntermediate.Models;

namespace CSharpIntermediate
{
    class DbCommand
    {
        private DbConnection connection { get; set; }
        private string Command { get; set; }

        public DbCommand(DbConnection db, string command)
        {
            if (db == null)
                throw new ArgumentNullException("Please ensure the database connection is valid.");

            if (string.IsNullOrEmpty(command))
                throw new ArgumentNullException("Please ensure you provide a command.");

            connection = db;
            Command = command;
        }

        public void Execute()
        {
            try
            {
                // Open the connection to the database.
                connection.OpenConnection();

                // Execute the required command.
                Console.WriteLine($"Executing '{Command}'...");

                // Inform the user that the command was successfully executed.
                Console.WriteLine("Command executed successfully.");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}