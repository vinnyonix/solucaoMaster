using System.Configuration;
using System.Data.SqlClient;

namespace solucaoData.Connection
{
    public class Conexao
    {
        private SqlConnection sqlConn;
        public SqlConnection openConnection()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["valor do atributo Name: no webconfig"].ConnectionString;
            string connectionString = ConfigurationManager.ConnectionStrings["solucaoMaster"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            this.sqlConn = sqlConn;
            return sqlConn;
        }
        public SqlConnection getConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["solucaoMaster"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            this.sqlConn = sqlConn;
            return sqlConn;
        }
        public void closeConnection()
        {
            sqlConn.Close();
        }
    }
}
