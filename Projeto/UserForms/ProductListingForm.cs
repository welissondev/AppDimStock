using DimStock.Auxiliarys;
using System;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class ProductListingForm : Form
    {
        public ProductListingForm()
        {
            InitializeComponent();
        }

        private void ProductListingForm_Load(object sender, EventArgs e)
        {
        }
        private void ProductListingForm_Resize(object sender, EventArgs e)
        {
        }

        private void ButtonShow_ProductAddForm_Click(object sender, EventArgs e)
        {
            var form = new ProductAddForm()
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false
            };

            form.ShowDialog();
        }
        private void ButtonUpdate_DatagridProduct_Click(object sender, EventArgs e)
        {
        }
        private void ButtonGenerate_Report_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void TextSearchInternalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void TextSearchDescription_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DatagridProduct_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }
        private void DatagridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void DatagridProduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DatagridProduct.Rows[e.RowIndex].Selected = true;
            }
        }
        private void DatagridProduct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
    }
}


