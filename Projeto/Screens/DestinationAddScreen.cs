using DimStock.AuxilyTools.AuxilyClasses;
using MetroFramework.Forms;
using System;
using DimStock.Presenters;
using DimStock.Views;
using System.Windows.Forms;
using MetroFramework;

namespace DimStock.Screens
{
    public partial class DestinationAddScreen : MetroForm, IDestinationAddView
    {
        private static MetroForm thisScreen;

        public int Id { get; set; }
        public string LocationDescription { get => TextLocationDescription.Text; set => TextLocationDescription.Text = value; }

        public DestinationAddScreen()
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
                Close();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public static void ShowScreen(Form mdi = null, Form owner = null)
        {
            try
            {
                var screen = new DestinationAddScreen();

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
        public static void SetDetails(IDestinationAddView view, MetroForm owner = null)
        {
            try
            {
                var screen = new DestinationAddScreen()
                {
                    Id = view.Id,
                    LocationDescription = view.LocationDescription,
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

        private void InitializeEvents()
        {
            try
            {
                Resize += new EventHandler(ScreenResize);
                ButtonSave.Click += new EventHandler(PresenterUpdate);
                ButtonDelete.Click += new EventHandler(PresenterDelete);
                ButtonClearView.Click += new EventHandler(PresenterClear);
                ButtonClose.Click += new EventHandler(ScreenClose);
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
                new DestinationAddPresenter(this).Update();
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
                new DestinationAddPresenter(this).Delete();
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
                new DestinationAddPresenter(this).Clear();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
