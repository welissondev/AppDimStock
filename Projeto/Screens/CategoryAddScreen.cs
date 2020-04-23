using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.Screens
{
    /// <summary>
    /// Representa um formulário de cadastro de categorias
    /// </summary>
    public partial class CategoryAddScreen : ICategoryAddView
    {
        public int Id { get; set; }
        public string Description { get => TextDescription.Text; set => TextDescription.Text = value; }

        private CategoryAddPresenter presenter;
    }
}

namespace DimStock.Screens
{
    public partial class CategoryAddScreen : MetroForm
    {
        public CategoryAddScreen()
        {
            InitializeComponent();
            presenter = new CategoryAddPresenter(this);
            InitializeEvents();
        }

        private void ScreenResize(object sender, EventArgs e)
        {
            Refresh();
        }
        private void ScreenClose(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeEvents()
        {
            ButtonSave.Click += new EventHandler(presenter.Update);
            ButtonDelete.Click += new EventHandler(presenter.Delete);
            ButtonClearView.Click += new EventHandler(presenter.ClearView);
            ButtonClose.Click += new EventHandler(ScreenClose);
            Resize += new EventHandler(ScreenResize);
        }

        public void ShowScreen(object sender, EventArgs e)
        {
            try
            {
                using (var categoryForm = new CategoryAddScreen())
                {
                    ShowInTaskbar = false;
                    ControlBox = false;
                    Owner = HomeScreen.He;
                    ShowDialog();
                };
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        public void SetDetails(ICategoryAddView view)
        {
            var screen = new CategoryAddScreen()
            {
                Id = view.Id,
                Description = view.Description,
                ControlBox = false,
                Owner = HomeScreen.He
            };

            screen.ShowDialog();
        }
    }
}