using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new OracleConnection("connectionstring");
            DbCommand command = new DbCommand(connection);
            command.Execute("select * from customers");
        }
    }
}
