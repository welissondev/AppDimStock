using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysEstoque.AXL
{
    public static class AxiDataGridViewLealt
    {
        public static void GetLayoutModelo1(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.FromArgb(223, 225, 226);
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 232, 236);
            datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(118, 106, 108);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 232, 236);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 70;
            datagrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 8.0F);
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 232, 236);
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowTemplate.MinimumHeight = 70;
            datagrid.AllowUserToAddRows = false;
            datagrid.BorderStyle = BorderStyle.Fixed3D;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ColumnHeadersVisible = true;
            datagrid.AllowUserToResizeColumns = false;
            datagrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            datagrid.AutoGenerateColumns = false;

        }

        public static void GetLayoutModelo2(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.FromArgb(223, 225, 226);
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 232, 236);
            datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(118, 106, 108);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 232, 236);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 50;
            datagrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 8.0F);
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 232, 236);
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowTemplate.MinimumHeight = 50;
            datagrid.AllowUserToAddRows = false;
            datagrid.BorderStyle = BorderStyle.None;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ColumnHeadersVisible = true;
            datagrid.AllowUserToResizeColumns = false;
            datagrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            datagrid.AutoGenerateColumns = false;

        }

        public static void GetLayoutModelo3(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.FromArgb(223, 225, 226);
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 52, 52);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 52, 52);
            datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(252, 252, 252);
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 50;
            datagrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 8.0F);
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(206, 237, 248);
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowTemplate.MinimumHeight = 50;
            datagrid.AllowUserToAddRows = false;
            datagrid.BorderStyle = BorderStyle.None;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ColumnHeadersVisible = true;
            datagrid.AllowUserToResizeColumns = false;
            datagrid.AutoGenerateColumns = false;

        }

        public static void GetLayoutModelo4(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.FromArgb(223, 225, 226);
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(10, 103, 180);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 103, 180);
            datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(252, 252, 252);
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 50;
            datagrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 8.0F);
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(206, 237, 248);
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowTemplate.MinimumHeight = 50;
            datagrid.AllowUserToAddRows = false;
            datagrid.BorderStyle = BorderStyle.None;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ColumnHeadersVisible = true;
            datagrid.AllowUserToResizeColumns = false;
            datagrid.AutoGenerateColumns = false;

        }
    }
}
