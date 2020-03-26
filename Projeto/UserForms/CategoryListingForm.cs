using DimStock.Auxiliarys;
using DimStock.Presenters;
using DimStock.Views;
using System;
using System.Drawing;
using System.Windows.Forms;


/// <summary>
/// Propriedades da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class CategoryListingForm : ICategoryListingView
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string SearchDescription { get => TextSearchDescription.Text; set => TextSearchDescription.Text = value; }
        public object DataList { get => DatagridCategory.DataSource; set => DatagridCategory.DataSource = value; }
    }
}

/// <summary>
/// Eventos do classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class CategoryListingForm : Form
    {
        public CategoryListingForm()
        {
            InitializeComponent();
            AddButtonColumnInDataGrid();
            AxlDataGridLealt.SetDefaultStyle(DatagridCategory);
        }

        private void CategoryListingForm_Load(object sender, EventArgs e)
        {
            SearchCategories();
        }

        private void ButtonShow_CategoryAddForm_Click(object sender, EventArgs e)
        {
            CategoryAddForm.ShowForm();
        }
        private void ButtonUpdate_DataGridCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var presenter = new CategoryListingPresenter(this);
                presenter.ResetView();

                SearchCategories();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        private void ButtonClear_ResetView_Click(object sender, EventArgs e)
        {
            try
            {
                var presenter = new CategoryListingPresenter(this);
                presenter.ResetView();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void TextSearchDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var presenter = new CategoryListingPresenter(this);
                presenter.FetchData();
            }
        }

        private void DatagridCategory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Selecione linha no datagrid ao passar o mouse
            if (e.RowIndex != -1)
            {
                DatagridCategory.Rows[e.RowIndex].Selected = true;
            }
        }
        private void DatagridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DatagridCategory.Rows.Count != 0)
                {
                    Id = int.Parse(DatagridCategory.CurrentRow.
                    Cells["Id"].Value.ToString());

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
                AxlException.Message.Show(ex);
            }
        }
        private void DatagridCategory_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }
    }
}

/// <summary>
/// Métodos auxiliares
/// </summary>
namespace DimStock.UserForms
{
    public partial class CategoryListingForm
    {
        private void ApplySettingsToDataGrid()
        {
            try
            {
                DatagridCategory.Columns["Id"].Visible = true;
                DatagridCategory.Columns["Id"].ReadOnly = true;
                DatagridCategory.Columns["Id"].DisplayIndex = 0;

                DatagridCategory.Columns["Description"].HeaderText = "Descrição";
                DatagridCategory.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DatagridCategory.Columns["Description"].ReadOnly = true;
                DatagridCategory.Columns["Description"].DisplayIndex = 1;

                DatagridCategory.Columns["ButtonView"].HeaderText = string.Empty;
                DatagridCategory.Columns["ButtonDelete"].HeaderText = string.Empty;

                DatagridCategory.AllowUserToAddRows = false;
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
                    ActiveLinkColor = Color.MediumAquamarine,
                    Width = 70,
                };
                DatagridCategory.Columns.Add(buttonView);


                var buttonDelete = new DataGridViewLinkColumn
                {
                    Name = "ButtonDelete",
                    Text = "Deletar",
                    TrackVisitedState = false,
                    UseColumnTextForLinkValue = true,
                    LinkColor = Color.Black,
                    ActiveLinkColor = Color.MediumAquamarine,
                    Width = 70
                };
                DatagridCategory.Columns.Add(buttonDelete);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void SearchCategories()
        {
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