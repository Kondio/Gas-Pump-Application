using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MetroFramework;

namespace GasPumpApplication
{
    public class DbConn
    {
        public SqlConnection sqlconn;


        public DbConn()
        {
            string connInfo = "Data Source=INTERN; Initial Catalog=AFC; Integrated Security=SSPI; User ID=sa; Password=Password01";

            sqlconn = new SqlConnection(connInfo);

        }

        public bool DbAuthentication(System.Windows.Forms.Form form, string usrname)
        {
            try
            {
                SqlCommand sqlc = new SqlCommand("SELECT count (*) as cnt FROM SY_USR WHERE USR_ID = @usr", sqlconn);
                sqlc.Parameters.Clear();
                sqlc.Parameters.AddWithValue("@usr", usrname);
                sqlconn.Open();
                if (sqlc.ExecuteScalar().ToString() == "1")
                {
                    MetroMessageBox.Show(form, "Authentication Successful");
                    return true;
                }
                else
                {
                    MetroMessageBox.Show(form, "An error occurred, try again");
                }
                
                sqlconn.Close();              

            }
            catch(SqlException ex)
            {
                MetroMessageBox.Show(form, ex.Message);
            }
            return false;

        }
         
    }
}
