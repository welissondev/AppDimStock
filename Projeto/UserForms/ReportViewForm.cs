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

        private ReportViewForm(string path, string reportName, bool isEmbeddedResource, Dictionary<string, object> dataSources)
        {
            InitializeComponent();

            ReportViewControl.LocalReport.DisplayName = reportName;

            SetEmbeddedResource(isEmbeddedResource, path);

            foreach (var dataSource in dataSources)
            {
                var reportDataSource = new ReportDataSource(
                dataSource.Key, dataSource.Value);

                ReportViewControl.LocalReport.DataSources.Add(
                reportDataSource);
            }

            SetCompanyLogo();
        }

        #endregion

        #region UserForm

        private void FrmReportView_Load(object sender, EventArgs e)
        {
            ReportViewControl.RefreshReport();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        public static void ShowReport(string path, string reportName, bool isEmbeddedResource, Dictionary<string, object> dataSources)
        {
            var form = new ReportViewForm(path, reportName,
            isEmbeddedResource, dataSources)
            {
                MdiParent = HomeScreenForm.He,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                ShowInTaskbar = false
            };

            form.Show();
        }

        private void SetEmbeddedResource(bool isEmbeddedResource, string path)
        {
            if (isEmbeddedResource)
            {
                ReportViewControl.LocalReport.ReportEmbeddedResource = path;
            }
            else
            {
                ReportViewControl.LocalReport.ReportPath = path;
            }
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
