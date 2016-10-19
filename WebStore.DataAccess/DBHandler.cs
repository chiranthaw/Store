using System.Configuration;
using System.Data.SqlClient;

namespace WebStore.DataAccess
{
    public class DBHandler
    {
        protected SqlConnection conn;

        public DBHandler()
        {
            string sConString = ConfigurationManager.ConnectionStrings["dbConnString"].ToString();
            conn = new SqlConnection(sConString);
        }
    }
}
