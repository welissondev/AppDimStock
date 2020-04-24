using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class HomeScreen : Form
    {
        private int childFormNumber = 0;
        public static HomeScreen He { get; set; }

        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {
            He = this;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form
            {
                MdiParent = this,
                Text = "Janela " + childFormNumber++
            };
            childForm.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                var homeScreen = this.Controls.OfType<MdiClient>().SingleOrDefault();
                homeScreen.BackColor = Color.White;
                this.SuspendLayout();
                homeScreen.SuspendLayout();
                var hdiff = homeScreen.Size.Width - homeScreen.ClientSize.Width;
                var vdiff = homeScreen.Size.Height - homeScreen.ClientSize.Height;
                var size = new Size(homeScreen.Width + hdiff, homeScreen.Height + vdiff);
                var location = new Point(homeScreen.Left - (hdiff / 2), homeScreen.Top - (vdiff / 2));
                homeScreen.Dock = DockStyle.None;
                homeScreen.Size = size;
                homeScreen.Location = location;
                homeScreen.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                homeScreen.ResumeLayout(true);
                this.ResumeLayout(true);
                base.OnLoad(e);
            }

            catch (Exception ex)
            {
                ex.GetType();
                this.Close();
            }
        }
    }
}
