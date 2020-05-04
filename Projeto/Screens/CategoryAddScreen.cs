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
        private static MetroForm thisScreen;

        public int Id { get; set; }
        public string Description { get => TextDescription.Text; set => TextDescription.Text = value; }
    }
}

namespace DimStock.Screens
{
    public partial class CategoryAddScreen : MetroForm
    {
        public CategoryAddScreen()
        {
            InitializeComponent();
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
                ButtonSave.Click += new EventHandler(PresenterInsert);
                ButtonDelete.Click += new EventHandler(PresenterUpdate);
                ButtonClearView.Click += new EventHandler(PresenterClear);
                ButtonClose.Click += new EventHandler(ScreenClose);
                Resize += new EventHandler(ScreenResize);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public static void SetDetails(ICategoryAddView view, MetroForm owner = null)
        {
            try
            {
                var screen = new CategoryAddScreen()
                {
                    Id = view.Id,
                    Description = view.Description,
                    ShowIcon = false,
                    ShowInTaskbar = false,
                    ControlBox = false
                };

                if (owner != null)
                    screen.Owner = owner;

                screen.ShowDialog();
                screen.Dispose();
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

        public static void ShowScreen(Form mdi = null, Form owner = null)
        {
            try
            {
                var screen = new CategoryAddScreen();

                if (mdi != null)
                {
                    screen.MdiParent = mdi;
                    screen.ShowInTaskbar = false;
                    screen.ControlBox = false;
                    screen.Dock = DockStyle.Fill;
                    screen.Style = MetroColorStyle.White;
                    screen.Movable = false;

                    screen.Show();
                }
                else
                {
                    screen.ShowInTaskbar = false;
                    screen.ControlBox = false;
                    screen.ShowIcon = false;
                    screen.Style = MetroColorStyle.Blue;

                    if (owner != null)
                        screen.Owner = owner;

                    screen.ShowDialog();
                    screen.Dispose();
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void PresenterInsert(object sender, EventArgs e)
        {
            try
            {
                new CategoryAddPresenter(this).Insert();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterUpdate(object sender, EventArgs e)
        {
            try
            {
                new CategoryAddPresenter(this).Update();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterDelete(object sender, EventArgs e)
        {
            try

            {
                new CategoryAddPresenter(this).Delete();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterClear(object sender, EventArgs e)
        {
            try
            {
                new CategoryAddPresenter(this).Clear();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}