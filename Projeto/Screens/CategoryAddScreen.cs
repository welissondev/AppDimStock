using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework;
using MetroFramework.Forms;
using System;
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
        private static MetroForm thisScreen;
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
            SetScreen();
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

        private void SetScreen()
        {
            thisScreen = this;
        }
        public static MetroForm GetScreen()
        {
            return thisScreen;
        }

        public static void ShowScreen(Form fatherScreen = null)
        {
            try
            {
                var screen = new CategoryAddScreen();

                if (fatherScreen != null)
                {
                    screen.MdiParent = fatherScreen;
                    screen.ShowInTaskbar = false;
                    screen.ControlBox = false;
                    screen.Dock = DockStyle.Fill;
                    screen.Style = MetroColorStyle.White;
                    screen.Show();
                }
                else
                {
                    screen.ShowInTaskbar = false;
                    screen.ControlBox = false;
                    screen.ShowIcon = false;
                    screen.Style = MetroColorStyle.Blue;

                    var listingScreen = CategoryListingScreen.GetScreen();
                    if (listingScreen != null)
                        screen.Owner = listingScreen;

                    screen.ShowDialog();
                    screen.Dispose();
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}