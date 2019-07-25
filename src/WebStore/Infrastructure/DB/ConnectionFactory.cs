using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WebStore.Infrastructure.DB
{
    public static class ConnectionFactory
    {
        private static string _sqlConnection =
            "server=23.98.153.101;database=DeveloperDB17;user=developer;password=dev123DEV123";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_sqlConnection);
        }
    }
}
