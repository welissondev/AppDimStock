using System.Drawing;
using System.Windows.Forms;

namespace DimStock.Auxiliary
{
    public static class DataGridLealt
    {
        public static void SetDefaultStyle(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.DarkGray;
            datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);  
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Bold);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 30;
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(206, 237, 248);
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowTemplate.MinimumHeight = 30;
            datagrid.RowsDefaultCellStyle.Font = new Font("Arial", 9.0F);
            datagrid.AllowUserToAddRows = false;
            datagrid.BorderStyle = BorderStyle.None;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            

            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ColumnHeadersVisible = true;
            datagrid.AllowUserToResizeColumns = false;
            datagrid.AutoGenerateColumns = false;
        }

        public static void DefineStyleItem(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.DarkGray;
            datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);  
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Bold);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 30;
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(206, 237, 248);
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.Font = new Font("Arial", 9.0F);
            datagrid.RowTemplate.MinimumHeight = 30;
            datagrid.AllowUserToAddRows = false;
            datagrid.BorderStyle = BorderStyle.Fixed3D;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            

            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ColumnHeadersVisible = true;
            datagrid.AllowUserToResizeColumns = false;
            datagrid.AutoGenerateColumns = false;
        }

        public static void SortColumnAsc(DataGridView datagrid, int colunaIndex)
        {
            datagrid.Sort(datagrid.Columns[colunaIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        public static void SortColumnDesc(DataGridView dtgGrid, int colunaIndex)
        {
            dtgGrid.Sort(dtgGrid.Columns[colunaIndex], System.ComponentModel.ListSortDirection.Descending);
        }
    }
}
