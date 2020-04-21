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
    public partial class CategoryAddForm : ICategoryAddView
    {
        public int Id { get; set; }
        public string Description { get => TextDescription.Text; set => TextDescription.Text = value; }

        private CategoryAddPresenter presenter;
    }
}

namespace DimStock.Screens
{
    public partial class CategoryAddForm : MetroForm
    {
        public CategoryAddForm()
        {
            InitializeComponent();
            presenter = new CategoryAddPresenter(this);
            InitializeEvents();
        }

        public CategoryAddForm(ICategoryAddView view)
        {
            InitializeComponent();
            presenter = new CategoryAddPresenter(this);
            InitializeEvents();

            Id = view.Id;
            Description = view.Description;
            ControlBox = false;
            Owner = HomeScreenForm.He;
        }

        private void ChangerSize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ScreenClose(object sender, EventArgs e)
        {
            Dispose();
        }

        private void InitializeEvents()
        {
            ButtonSave.Click += new EventHandler(presenter.Update);
            ButtonDelete.Click += new EventHandler(presenter.Delete);
            ButtonClearView.Click += new EventHandler(presenter.ClearView);
            ButtonClose.Click += new EventHandler(ScreenClose);
            Resize += new EventHandler(ChangerSize);
        }

        public static void ShowScreen(object sender, EventArgs e)
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

        public static void SetDetails(ICategoryAddView view)
        {
            var screen = new CategoryAddForm()
            {
                Id = view.Id,
                Description = view.Description,
                ControlBox = false,
                Owner = HomeScreenForm.He
            };

            screen.ShowDialog();
        }

    }
}