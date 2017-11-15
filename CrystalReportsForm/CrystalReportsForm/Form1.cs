using CrystalReportsForm.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystalReportsForm
{
    public partial class Form1 : Form
    {
        CrystalReport1 cr = new CrystalReport1();
        DataSet ds = new DataSet();
        IM_ITEMTableAdapter adp = new IM_ITEMTableAdapter();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ParameterFieldDefinitions crParameterFieldDefinitions ;
            ParameterFieldDefinition crParameterFieldDefinition ;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = textBox1.Text;
            crParameterFieldDefinitions = cr.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["Category"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();  
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            adp.Fill(ds.IM_ITEM);
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            cr.SetParameterValue(0, textBox1.Text);
            crystalReportViewer1.Refresh();
        }
    }
}
