using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace DimStock.View
{
    public partial class FrmReportView : Form
    {
        #region Constructors
        private FrmReportView(string path, bool isEmbeddedResource, Dictionary<string,
        object> dataSources, Dictionary<string, object> reportParameters = null)
        {

            InitializeComponent();

            #region Path + isEmbeddedResource
            if (isEmbeddedResource)
            {
                RpvReportView.LocalReport.ReportEmbeddedResource = path;
            }
            else
            {
                RpvReportView.LocalReport.ReportPath = path;
            }
            #endregion

            #region DataSources
            foreach (var dataSource in dataSources)
            {
                var reportDataSource = new ReportDataSource(dataSource.Key, dataSource.Value);
                this.RpvReportView.LocalReport.DataSources.Add(reportDataSource);
            }
            #endregion

            #region ReportParameters
            if (reportParameters != null)
            {
                var reportParameterCollection = new List<ReportParameter>();

                foreach (var parameter in reportParameters)
                {
                    var reportParameter = new ReportParameter(parameter.Key, parameter.Value.ToString());
                    reportParameterCollection.Add(reportParameter);
                }

                RpvReportView.LocalReport.SetParameters(reportParameterCollection);
            }
            #endregion

        }
        #endregion

        #region FrmReportView_Load()
        private void FrmReportView_Load(object sender, EventArgs e)
        {

            RpvReportView.RefreshReport();
        }
        #endregion

        #region ShowReport()
        public static void ShowReport(string path, bool isEmbeddedResource,
        Dictionary<string, object> dataSources, Dictionary<string, object> reportParameters = null)
        {
            var frmReportView = new FrmReportView(path, isEmbeddedResource,
            dataSources, reportParameters);

            frmReportView.Show();
        }
        #endregion
    }
}
