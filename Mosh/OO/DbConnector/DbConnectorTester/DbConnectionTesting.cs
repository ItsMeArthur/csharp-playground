using DbConnector;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DbConnectorTester
{
    [TestClass]
    public class DbConnectionTesting
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OpeningConnectionWithNullConnectionString()
        {
            SqlConnection dbConnection = new SqlConnection(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OpeningConnectionWithEmptyConnectionString()
        {
            SqlConnection dbConnection = new SqlConnection(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OpeningConnectionWithWhispacesConnectionString()
        {
            SqlConnection dbConnection = new SqlConnection(" ");
        }

        [TestMethod]
        public void SqlConnectionOpen()
        {
            SqlConnection dbConnection = new SqlConnection("connectionstring");

            Assert.P
        }

        [TestMethod]
        public void SqlConnectionClose()
        {
            SqlConnection dbConnection = new SqlConnection(" ");
        }




    }
}
