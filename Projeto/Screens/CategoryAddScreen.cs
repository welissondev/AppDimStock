using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework.Forms;
using System;

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
            try
            {
                Refresh();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void ScreenClose(object sender, EventArgs e)
        {
            try
            {
                if (this != null)
                    Close();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void InitializeEvents()
        {
            try
            {
                ButtonSave.Click += new EventHandler(presenter.Update);
                ButtonDelete.Click += new EventHandler(presenter.Delete);
                ButtonClearView.Click += new EventHandler(presenter.ClearView);
                ButtonClose.Click += new EventHandler(ScreenClose);
                Resize += new EventHandler(ScreenResize);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void ShowScreen(object sender, EventArgs e)
        {
            try
            {
                using (var categoryForm = new CategoryAddScreen())
                {
                    ShowInTaskbar = false;
                    ControlBox = false;
                    Owner = HomeScreen.GetScreen();
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
            try
            {
                using (var screen = new CategoryAddScreen())
                {
                    Id = view.Id;
                    Description = view.Description;
                    ControlBox = false;
                    Owner = HomeScreen.GetScreen();
                    ShowDialog();
                };
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}