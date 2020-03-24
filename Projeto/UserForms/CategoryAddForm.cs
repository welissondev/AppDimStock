using DimStock.Auxiliarys;
using DimStock.Presenters;
using DimStock.Views;
using System;
using System.Windows.Forms;


/// <summary>
/// Métodos da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class CategoryAddForm : ICategoryAddView
    {
        public int Id { get; set; }
        public string Description { get => TextDescription.Text; set => TextDescription.Text = value; }
    }
}

/// <summary>
/// Eventos da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class CategoryAddForm : Form
    {
        public CategoryAddForm()
        {
            InitializeComponent();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var presenter = new CategoryAddPresenter(this);
                var actionResult = presenter.Update();

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
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão dessa categoria?", "IMPORTANTE",
                MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) ==
                DialogResult.No) return;

                var presenter = new CategoryAddPresenter(this);
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
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ButtonResetView_Click(object sender, EventArgs e)
        {
            try
            {
                var presenter = new CategoryAddPresenter(this);
                presenter.ResetView();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
    }
}

/// <summary>
/// Métodos auxiliares
/// </summary>
namespace DimStock.UserForms
{
    public partial class CategoryAddForm
    {
        public static void ShowForm()
        {
            try
            {
                var categoryForm = new CategoryAddForm()
                {
                    ShowInTaskbar = false,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                categoryForm.ShowDialog();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }

        }

        public static void SetDetail(ICategoryAddView view)
        {
            var categoryAddForm = new CategoryAddForm()
            {
                Id = view.Id,
                Description = view.Description,
                ShowInTaskbar = false,
                MinimizeBox = false
            };

            categoryAddForm.ShowDialog();
        }
    }
}