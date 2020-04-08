using System;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.AuxilyTools.Controls
{
    public partial class CustomDataGridViewTwo
    {
        private bool customSettings = false;
        public bool CustomSettings { get => customSettings; set => customSettings = value; }
    }
}

namespace DimStock.AuxilyTools.Controls
{
    public partial class CustomDataGridViewTwo : DataGridView
    {
        public CustomDataGridViewTwo()
        {
            InitializeComponent();
            SetDefaultSetting();
        }

        private void DataSourceChanger(object sender, EventArgs e)
        {
            if (Rows.Count == 0)
            {
                Visible = false;
                return;
            }

            switch (Visible)
            {
                case false:
                    Visible = true; SetControlSize(120);
                    break;
            }
        }

        private void MouseOverEffect(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Rows[e.RowIndex].Selected = true;
            }
        }

        private void MouseHearsClick(object sender, EventArgs e)
        {
            switch (Visible)
            {
                case true:
                    Visible = false;
                    break;
            }
        }

        public void SetControlSize(int heith)
        {
            Height = heith;
        }

        public void SetDefaultSetting()
        {
            switch (customSettings)
            {
                case false:
                    Visible = false;
                    AllowUserToAddRows = false;
                    RowHeadersVisible = false;
                    BackgroundColor = Color.White;
                    AllowUserToResizeRows = false;
                    ColumnHeadersVisible = false;
                    MultiSelect = false;
                    ReadOnly = false;
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    BorderStyle = BorderStyle.Fixed3D;
                    RowsDefaultCellStyle.Font = new Font("Calibri Light", 10.0F);
                    break;
            }
        }

        public void InitializeComponent()
        {
            DataSourceChanged += new EventHandler(DataSourceChanger);

            CellMouseEnter += new DataGridViewCellEventHandler(MouseOverEffect);

            Click += new EventHandler(MouseHearsClick);
        }
    }
}
