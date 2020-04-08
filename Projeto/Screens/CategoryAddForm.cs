using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;


/// <summary>
/// Métodos da classe
/// </summary>
namespace DimStock.Screens
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
namespace DimStock.Screens
{
    public partial class CategoryAddForm : MetroForm
    {
        public CategoryAddForm()
        {
            InitializeComponent();
        }

        private void CategoryAddForm_Resize(object sender, EventArgs e)
        {
            try
            {
                Refresh();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var actionResult = false;

                var presenter = new CategoryAddPresenter(this);

                if (Id == 0)
                    actionResult = presenter.Insert();

                if (Id > 0)
                    actionResult = presenter.Update();

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
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void ButtonClearView_Click(object sender, EventArgs e)
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
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

/// <summary>
/// Métodos auxiliares
/// </summary>
namespace DimStock.Screens
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
                    ControlBox = false,
                    Owner = HomeScreenForm.He
                };

                categoryForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public static void SetDetail(ICategoryAddView view)
        {
            var categoryAddForm = new CategoryAddForm()
            {
                Id = view.Id,
                Description = view.Description,
                ControlBox = false,
                Owner = HomeScreenForm.He
            };

            categoryAddForm.ShowDialog();
        }

        private void ClearView()
        {
            var presenter = new CategoryAddPresenter(this);
            presenter.ResetView();

            TextDescription.Focus();
        }
    }
}