using Crud.Shared;
using System.Data.SqlClient;

namespace Crud.Infra.Data.Dapper
{
    public class DataContext
    {
        public SqlConnection Connection { get; set; }

        public DataContext()
        {
            Connection = new SqlConnection(Settings.ConnectionString);
            Connection.Open();
        }
    }
    
}

