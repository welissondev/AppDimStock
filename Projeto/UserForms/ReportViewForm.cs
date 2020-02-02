using DimStock.Auxiliarys;
using DimStock.Business;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class ReportViewForm : Form
    {
        #region Constructors
        private ReportViewForm(string path, string reportName, bool isEmbeddedResource, Dictionary<string,
        object> dataSources, Dictionary<string, object> reportParameters = null)
        {

            InitializeComponent();

            ReportViewControl.LocalReport.DisplayName = reportName;

            if (isEmbeddedResource)
            {
                ReportViewControl.LocalReport.ReportEmbeddedResource = path;
            }
            else
            {
                ReportViewControl.LocalReport.ReportPath = path;
            }

            foreach (var dataSource in dataSources)
            {
                var reportDataSource = new ReportDataSource(dataSource.Key, dataSource.Value);
                this.ReportViewControl.LocalReport.DataSources.Add(reportDataSource);
            }

            if (reportParameters != null)
            {
                var reportParameterCollection = new List<ReportParameter>();

                foreach (var parameter in reportParameters)
                {
                    var reportParameter = new ReportParameter(parameter.Key, parameter.Value.ToString());
                    reportParameterCollection.Add(reportParameter);
                }

                ReportViewControl.LocalReport.SetParameters(reportParameterCollection);
            }
        }
        #endregion

        #region UserForm

        private void FrmReportView_Load(object sender, EventArgs e)
        {
            SetCompanyLogo();

            ReportViewControl.RefreshReport();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        public static void ShowReport(string path, string reportName,
        bool isEmbeddedResource, Dictionary<string, object> dataSources,
        Dictionary<string, object> reportParameters = null)
        {
            var form = new ReportViewForm(path, reportName,
            isEmbeddedResource, dataSources, reportParameters)
            {
                MdiParent = HomeScreenForm.He,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                ShowInTaskbar = false
            };

            form.Show();
        }

        private void SetCompanyLogo()
        {
            try
            {
                var parameters = new ReportParameterCollection();

                var imagePath = AppSetting.GetMainAppDirectory() +
                @"\CompanyLogo\CompanyLogo.jpg";

                parameters.Add(new ReportParameter("CompanyLogoPath",
                @"file:\" + imagePath));

                ReportViewControl.LocalReport.SetParameters(parameters);

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion
    }
}
