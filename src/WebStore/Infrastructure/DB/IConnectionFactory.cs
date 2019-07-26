using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WebStore.Infrastructure.DB
{
    public interface IConnectionFactory
    {
        SqlConnection GetConnection();
    }
}
