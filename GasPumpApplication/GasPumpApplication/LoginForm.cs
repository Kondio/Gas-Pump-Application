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

namespace GasPumpApplication
{
    public partial class LoginForm : MetroForm
    {
        DbConn conn;
        public LoginForm()
        {
            InitializeComponent();
            conn = new DbConn();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(conn.DbAuthentication(this, metroTextBox1.Text))
            {
                MainMenuForm form2 = new MainMenuForm();              
                form2.Show();
                Hide();
            }
        }
    }
}
