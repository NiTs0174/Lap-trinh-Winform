using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        //----------------------------
        private void DoanhThu_Load(object sender, EventArgs e)
        {
                reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.TkVe.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = modify.Table("select * from VE"); 
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();            
        }
    }
}
