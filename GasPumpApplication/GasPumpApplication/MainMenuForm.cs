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
using MetroFramework.Forms;

namespace GasPumpApplication
{
    public partial class MainMenuForm : MetroForm
    {
        PumpsControl pumps;
        SetupScreen setup;
        ReportsViewsScreen reports;
        public MainMenuForm()
        {       
            InitializeComponent();
            
   
        }

        private void RepView_Click(object sender, EventArgs e)
        {
            ShowNextForm(sender, e);
        }

        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            ShowNextForm(sender, e);
        }

        private void Pumpsbtn_Click_1(object sender, EventArgs e)
        {
            ShowNextForm(sender,e);
        }

        private void ShowNextForm(object sender, EventArgs e)
        {
            var clicked = (((MetroFramework.Controls.MetroTile)sender).Name);
            switch(clicked)
            {
                case "Pumpsbtn":
                    if (pumps == null)
                        pumps = new PumpsControl();
                    this.Hide();
                    pumps.FormClosed += (s, args) => this.Close();
                    pumps.Show();
                    break;
                case "Settingsbtn":
                    if (setup == null)
                        setup = new SetupScreen();
                    this.Hide();
                    setup.FormClosed += (s, args) => this.Close();
                    setup.Show();
                    break;
                case "RepView":
                    if (reports == null)
                        reports = new ReportsViewsScreen();
                    this.Hide();
                    reports.FormClosed += (s, args) => this.Close();
                    reports.Show();
                    break;




            }
        }
    }
   }

