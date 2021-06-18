using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class ReportViewScreen : Form
    {
        #region Builder

        private ReportViewScreen(string path, string reportName, bool isEmbeddedResource, Dictionary<string, object> dataSources)
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

        #region Form

        private void FrmReportView_Load(object sender, EventArgs e)
        {
            ReportViewControl.RefreshReport();
        }

       
        #endregion

        #region Button

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Function

        public static void ShowReport(string path, string reportName, bool isEmbeddedResource, Dictionary<string, object> dataSources)
        {
            var form = new ReportViewScreen(path, reportName,
            isEmbeddedResource, dataSources)
            {
                MdiParent = HomeScreen.GetScreen(),
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

                var imagePath = AppSettingModel.GetMainAppDirectory() +
                @"\CompanyLogo\CompanyLogo.jpg";

                parameters.Add(new ReportParameter("CompanyLogoPath",
                @"file:\" + imagePath));

                ReportViewControl.LocalReport.SetParameters(parameters);

            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        #endregion
    }
}
