using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bx
{
    public class Database
    {
        private SqlConnection connection;
        private SqlConnection sqlCon;
        private DataSet ds;
        private SqlDataAdapter da;

        public Database()
        {

            sqlCon = new SqlConnection("Data Source=MSI\\TRIEUHIEU;Initial Catalog=QLCHXM;User ID=sa;Password=trieuphuchieu;TrustServerCertificate=True;");
        }
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlCon);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();
                command.Connection = sqlCon;
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Loi xu li du lieu");
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

    }
}