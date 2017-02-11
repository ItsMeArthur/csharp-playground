using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnector
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : 
            base(connectionString)
        {
            
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection was closed.");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle connection was opened.");
        }
    }
}
