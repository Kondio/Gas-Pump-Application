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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace GasPumpApplication
{
    public partial class ReportsViewsScreen : MetroForm
    {
        MainMenuForm formmenu;

        public ReportsViewsScreen()
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            ReportDocument report = new ReportDocument();
            string filepath = openFileDialog1.FileName;
            report.Load(filepath);
            report.SetDatabaseLogon("sa", "Password01");
            crystalReportViewer1.ReportSource = report;
        }
    }
}
