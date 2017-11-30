using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using GasPumpApplication;

namespace GasPumpApplcation
{
    public partial class Form1 : MetroForm
    {
        public static DbConn conn;
        public Form1()
        {
            InitializeComponent();
            conn = new DbConn();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(conn.DbAuthentication(this, metroTextBox1.Text))
            {
                Form2 form2 = new Form2();              
                form2.Show();
                Hide();
            }
        }
    }
}
