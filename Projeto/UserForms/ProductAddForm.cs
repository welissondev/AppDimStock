using DimStock.Views;
using System;
using System.Windows.Forms;

/// <summary>
/// Propriedades da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class ProductAddForm : IProductAddView
    {
        public int Id { get; set; }
        public string InternalCode { get => TextInternalCode.Text; set => TextInternalCode.Text = value; }
        public string Description { get => TextDescription.Text; set => TextDescription.Text = value; }
        public double CostPrice { get => double.Parse(TextCostPrice.DecimalValue.ToString()); set => TextCostPrice.DecimalValue = decimal.Parse(value.ToString()); }
        public double SalePrice { get => double.Parse(TextSalePrice.DecimalValue.ToString()); set => TextSalePrice.DecimalValue = decimal.Parse(value.ToString()); }
        public string BarCode { get => TextBarCode.Text; set => TextBarCode.Text = value; }
        public string CategoryDescription { get => BoxCategory.Text; set => BoxCategory.Text = value; }
        public int CategoryId { get; set; }
    }
}

/// <summary>
/// Eventos da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class ProductAddForm : Form
    {
        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void ProductAddForm_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }
        private void ButtonPresenter_ResetView_Click(object sender, EventArgs e)
        {
            
        }
        private void ButtonShow_CategoryAddForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void BoxCategory_Click(object sender, EventArgs e)
        {

        }
        private void BoxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}

/// <summary>
/// Métodos Auxiliares da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class ProductAddForm
    {

    }
}
