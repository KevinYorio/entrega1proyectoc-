using System.Data.SqlClient;

namespace SistemaGestion.Data
{
    public static class ConnectionADO
    {
        private static string connectionString = @"Server=TU_SERVIDOR;Database=SistemaGestion;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
