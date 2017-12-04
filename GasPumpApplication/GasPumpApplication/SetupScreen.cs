using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasPumpApplication
{
    public partial class SetupScreen : MetroForm
    {
        MainMenuForm formmenu;
        public SetupScreen()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            if (formmenu == null)
                formmenu = new MainMenuForm();
            this.Visible = false;
            formmenu.Show();
        }
    }
}
