using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MetroFramework;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace GasPumpApplication
{
    public class DbConn
    {
      
        public void Connect()
        {
            if(sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
        }
        public void Disconnect()
        {
            if (sqlconn.State == ConnectionState.Open)
            {
                sqlconn.Close();
            }
        }


        private static string GetConnectionInfo()
        {

            string basepath = Application.StartupPath;
            string txtpath = basepath + "\\connString.txt";
            string connString = "";
            try
            {
                if(File.Exists(txtpath))
                {
                    using (StreamReader sr = new StreamReader(txtpath))
                    {
                        while(sr.Peek() >= 0)
                        {
                            string ss = sr.ReadLine();
                            string[] txtsplit = ss.Split(';');

                            //now retrieve the items in the array

                            string server = txtsplit[0].ToString();
                            string dbname = txtsplit[1].ToString();
                            string username = txtsplit[3].ToString();
                            string password = txtsplit[4].ToString();
                            connString = server + ";" + dbname+ ";"  + "; Integrated Security=True;" +username+";"+ password;
                        }
                    }
                }
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            return connString;


        }
        public SqlConnection sqlconn = new SqlConnection(GetConnectionInfo());
        //Authentication of the user
        //Use the parameter username passed from the textbox field and check if it exists in the database
        public bool DbAuthentication(Form form, string usrname)
        {
            try
            {
                SqlCommand sqlc = new SqlCommand("SELECT count (*) as cnt FROM SY_USR WHERE USR_ID = @usr", sqlconn);
                sqlc.Parameters.Clear();
                sqlc.Parameters.AddWithValue("@usr", usrname);
                //sqlconn.Open();
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
