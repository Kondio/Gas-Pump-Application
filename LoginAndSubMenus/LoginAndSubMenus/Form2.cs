using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginAndSubMenus
{
    public partial class Form2 : Form
    {
        DataSet ds;
        SqlDataAdapter sa;
        SqlConnection conn;

        public Form2()
        {
            InitializeComponent();
            sa = new SqlDataAdapter();
            ds = new DataSet();
            
            try
            {

                conn = new SqlConnection();
                 conn.ConnectionString = "Data Source=INTERN; Initial Catalog=AFC; Integrated Security=SSPI; User ID=sa; Password=Password01";
                    

                
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection to database failed");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.SY_USR", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // while there is another record present
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader.GetValue(0));

                    }
                }
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Query could not execute");
            }

            }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter sqld = new SqlDataAdapter();
            try
            {
                conn.Open();
                
                DataTable table = conn.GetSchema("Tables");


                string tablename = "";

                foreach (DataRow dr in table.Rows)
                {
                    if (dr[2].ToString() == "SY_CURNCY_UNITS")
                        tablename = dr[2].ToString();
                }

                label3.Text = tablename;
                conn.Close();
               
              

            }
            catch
            {
                MessageBox.Show("Error");
            }

            if (comboBox1.SelectedItem.ToString() == "HOME")
            {
                
                sqld.SelectCommand = new SqlCommand("SELECT * FROM dbo.SY_CURNCY_UNITS WHERE CURNCY_COD='HOME'", conn);
                ds2.Clear();
                sqld.Fill(ds2);
                dataGridView1.DataSource = ds2.Tables[0];
                
            }
            else if(comboBox1.SelectedItem.ToString()=="NAF")
            {
                
                sqld.SelectCommand = new SqlCommand("SELECT * FROM dbo.SY_CURNCY_UNITS WHERE CURNCY_COD='NAF'", conn);
                ds2.Clear();
                sqld.Fill(ds2);
                dataGridView1.DataSource = ds2.Tables[0];
            }

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string pid = textBox1.Text;
                string pdesc = textBox4.Text;
                string dummyuser = "dummyuser";
                
                
                string sqlquery = "INSERT into dbo.SY_PUMP (PUMP_ID, DESCR, LST_MAINT_DT, LST_MAINT_USR_ID) VALUES (@pumpID, @pumpDesc, @dt, @user)";

                using(SqlCommand pumpQuery = new SqlCommand(sqlquery, conn))
                {
                    conn.Open();
                    pumpQuery.Parameters.Add("@pumpID", SqlDbType.VarChar, 10).Value = pid;
                    pumpQuery.Parameters.Add("@pumpDesc", SqlDbType.VarChar, 30).Value = pdesc;
                    pumpQuery.Parameters.Add("@dt", SqlDbType.DateTime).Value = DateTime.Now;
                    pumpQuery.Parameters.Add("@user", SqlDbType.VarChar, 10).Value = dummyuser;
                    pumpQuery.ExecuteNonQuery();

                }
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Query couldn't execute");
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> usernames = new List<string>();
            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT USR_ID FROM dbo.SY_USR", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // while there is another record present
                    while (reader.Read())
                    {
                        usernames.Add(reader.GetValue(0).ToString());

                    }
                }
                conn.Close();

            }
            catch
            {

            }
            foreach (string s in usernames)
            {


                if (listBox1.SelectedItem.ToString()==s)
                {
                    string par = s;
                    
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.SY_USR WHERE USR_ID = @par", conn);
                    cmd.Parameters.Add("par", SqlDbType.VarChar).Value = par;
                    sa.SelectCommand = cmd;

                    ds.Clear();
                    sa.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    

                }

                else if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("You have not selected an employee");
                }
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            //this.Refresh();
            //foreach(Button b in this.Controls.OfType<Button>())
            //{
            //    b.Location = new Point((this.ClientRectangle.Width / 2), (this.ClientRectangle.Height / 2) + 100);
            //}
            //panel1.Location = new Point((this.ClientRectangle.Width / 2) -60 , (this.ClientRectangle.Height / 2) -200);
            //panel2.Location = new Point((this.ClientRectangle.Width / 2), (this.ClientRectangle.Height / 2) + 100);
            //tabControl1.Location = new Point((this.ClientRectangle.Width / 2), (this.ClientRectangle.Height / 2) + 100);
            //foreach(Label l in this.Controls.OfType<Label>())
            //{
            //    l.Location = new Point((this.ClientRectangle.Width / 2), (this.ClientRectangle.Height / 2) + 100);
            //}
            //foreach(TextBox t in this.Controls.OfType<TextBox>())
            //{
            //    t.Location = new Point((this.ClientRectangle.Width / 2), (this.ClientRectangle.Height / 2) + 100);
            //}
        }
    }
   }

