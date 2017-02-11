using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnector
{
    class DbCommand
    {
        private readonly DbConnection _connection;

        public DbCommand(DbConnection connection)
        {
            if (connection == null)
                throw new ArgumentException("Connection is null");

            _connection = connection;
        }

        public void Execute(string sqlCommand)
        {
            if (string.IsNullOrWhiteSpace(sqlCommand))
                throw new ArgumentException("Sql command cannot be null, empty or whitespace.");

            _connection.Open();
            Console.WriteLine($"Executed command: {sqlCommand}");
            _connection.Close();
        }
    }
}
