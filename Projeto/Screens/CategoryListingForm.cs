using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;


/// <summary>
/// Propriedades da classe
/// </summary>
namespace DimStock.Screens
{
    public partial class CategoryListingForm : ICategoryListingView
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string SearchDescription { get => TextSearch_Category.Text; set => TextSearch_Category.Text = value; }
        public object DataList { get => DatagridCategory.DataSource; set => DatagridCategory.DataSource = value; }

    }
}

/// <summary>
/// Eventos do classe
/// </summary>
namespace DimStock.Screens
{
    public partial class CategoryListingForm : MetroForm
    {
        public CategoryListingForm()
        {
            InitializeComponent();
            AddButtonColumnInDataGrid();
        }

        private void CategoryListingForm_Load(object sender, EventArgs e)
        {
            SearchCategory();
        }
        private void CategoryListingForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ButtonShow_CategoryAddForm_Click(object sender, EventArgs e)
        {
            CategoryAddForm.ShowForm();
        }
        private void ButtonClear_SearchFields_Click(object sender, EventArgs e)
        {
            try
            {
                ClearView();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void ButtonUpdate_DataGridCategory_Click(object sender, EventArgs e)
        {
            try
            {
                ClearView();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DatagridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DatagridCategory.Rows.Count != 0)
                {
                    Id = int.Parse(DatagridCategory.CurrentRow.
                    Cells["Id"].Value.ToString());

                    Description = DatagridCategory.CurrentRow.
                    Cells["Description"].Value.ToString();

                    var selectedButton = DatagridCategory.Columns
                    [e.ColumnIndex].Name;

                    switch (selectedButton)
                    {
                        case "ButtonView":

                            GetCategoryDetail();

                            break;

                        case "ButtonDelete":

                            DeleteCategory();

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void DatagridCategory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DatagridCategory.Rows[e.RowIndex].Selected = true;
            }
        }
        private void DatagridCategory_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }

        private void TextSearch_Category_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImageLoading.Visible = true;
            TimerSearch.Enabled = false;
            TimerSearch.Enabled = true;
        }

        private void TimerSearch_Tick(object sender, EventArgs e)
        {
            try
            {
                SearchCategory();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}

/// <summary>
/// Métodos auxiliares
/// </summary>
namespace DimStock.Screens
{
    public partial class CategoryListingForm
    {
        public static void ShowForm()
        {
            var categoryListingForm = new CategoryListingForm()
            {
                ShowIcon = false,
                ShowInTaskbar = false,
                ControlBox = false,
                Owner = HomeScreenForm.He
            };
            categoryListingForm.ShowDialog();
        }

        private void ApplySettingsToDataGrid()
        {
            try
            {
                DatagridCategory.Columns["Id"].Visible = false;
                DatagridCategory.Columns["Id"].ReadOnly = true;
                DatagridCategory.Columns["Id"].DisplayIndex = 0;

                DatagridCategory.Columns["Description"].HeaderText = "Descrição";
                DatagridCategory.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DatagridCategory.Columns["Description"].ReadOnly = true;
                DatagridCategory.Columns["Description"].DisplayIndex = 1;

                DatagridCategory.Columns["ButtonView"].HeaderText = string.Empty;
                DatagridCategory.Columns["ButtonView"].Width = 70;

                DatagridCategory.Columns["ButtonDelete"].Width = 70;
                DatagridCategory.Columns["ButtonDelete"].HeaderText = string.Empty;

                DatagridCategory.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 100, 148);
                DatagridCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 100, 148);
                DatagridCategory.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 220, 236);

                DatagridCategory.AllowUserToAddRows = false;
                DatagridCategory.MultiSelect = false;
                DatagridCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                DatagridCategory.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro em tempo de execução",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButtonColumnInDataGrid()
        {
            try
            {
                var buttonView = new DataGridViewLinkColumn
                {
                    Name = "ButtonView",
                    Text = "Visualizar",
                    TrackVisitedState = false,
                    UseColumnTextForLinkValue = true,
                    LinkColor = Color.Black,
                    ActiveLinkColor = Color.Black,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 100,
                };
                DatagridCategory.Columns.Add(buttonView);


                var buttonDelete = new DataGridViewLinkColumn
                {
                    Name = "ButtonDelete",
                    Text = "Deletar",
                    TrackVisitedState = false,
                    UseColumnTextForLinkValue = true,
                    LinkColor = Color.Black,
                    ActiveLinkColor = Color.Black,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 100,
                };
                DatagridCategory.Columns.Add(buttonDelete);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ClearView()
        {
            var presenter = new CategoryListingPresenter(this);
            presenter.ResetView();

            SearchCategory();
        }

        private void SearchCategory()
        {
            TimerSearch.Enabled = false;
            ImageLoading.Visible = false;

            var presenter = new CategoryListingPresenter(this);
            var dataList = presenter.FetchData();

            if (dataList.Rows.Count > 0)
                ApplySettingsToDataGrid();
        }

        private void DeleteCategory()
        {
            if (MessageBox.Show("Confirma a exclusão dessa categoria?", "IMPORTANTE",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) ==
            DialogResult.No) return;

            var presenter = new CategoryListingPresenter(this);
            var actionResult = presenter.Delete();

            switch (actionResult)
            {
                case true:
                    MessageBox.Show(MessageNotifier.Message, MessageNotifier.Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case false:
                    MessageBox.Show(MessageNotifier.Message, MessageNotifier.Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void GetCategoryDetail()
        {
            var presenter = new CategoryListingPresenter(this);
            var actionResult = presenter.GetDetail();

            switch (actionResult)
            {
                case true:
                    CategoryAddForm.SetDetail(this);
                    break;

                case false:
                    MessageBox.Show(MessageNotifier.Message, MessageNotifier.Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }
    }
}