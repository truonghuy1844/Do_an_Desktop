using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_DTO;
using PC_BLL;

namespace PC_GUI
{
    public partial class ReportDGNCC : Form
    {
        BLLNCC bLLNCC = new BLLNCC();
        public ReportDGNCC()
        {
            InitializeComponent();
            ReportDataSource rds = new ReportDataSource("DGNCCDataset", bLLNCC.LoadDGNCCReport());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = "PC_GUI.ReportDGNCC.rdlc";
            reportViewer1.RefreshReport();
        }

        private void ReportDGNCC_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
