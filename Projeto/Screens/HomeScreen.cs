using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class HomeScreen : Form
    {
        private static HomeScreen instance;

        public HomeScreen()
        {
            InitializeComponent();
            InitializeEvents();
            instance = this;
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
        }

        private void ShowCategoryAddScreen(object sender, EventArgs e)
        {
            var screen = new ProductListingScreen()
            {
                MdiParent = this,
                Dock = DockStyle.Fill,
                ControlBox = false,
                Movable = false
            };
            screen.Show();
        }

        private void InitializeEvents()
        {
            Load += new EventHandler(ScreenLoad);
            categoriaToolStripMenuItem.Click += new EventHandler(ShowCategoryAddScreen);
            bunifuButton2.Click += new EventHandler(ShowCategoryAddScreen);
        }

        protected override void OnLoad(EventArgs e)
        {
            //*Remove 3d do mdi e troca a cor de fundo*//

            try
            {
                var homeScreen = Controls.OfType<MdiClient>().SingleOrDefault();
                homeScreen.BackColor = Color.White;
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
                base.OnLoad(e);
            }

            catch (Exception ex)
            {
                ex.GetType();
            }
        }

        public static HomeScreen GetInstance()
        {
            return instance;
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
