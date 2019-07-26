using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WebStore.Infrastructure.DB
{
    public class ConnectionFactory : IConnectionFactory
    {
        private const string _sqlConnection =
            "server=191.234.179.75;database=DeveloperDB17;user=developers;password=dev123DEV123";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_sqlConnection);
        }
    }
}
