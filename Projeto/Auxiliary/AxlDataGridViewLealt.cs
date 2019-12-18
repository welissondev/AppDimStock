using System.Drawing;
using System.Windows.Forms;

namespace DimStock.Auxiliary
{
    public static class AxlDataGridViewLealt
    {
        #region DefaultLayoutDarkblue()
        public static void DefaultLayoutDarkblue(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.FromArgb(223, 225, 226);
            datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);  
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 40;
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(206, 237, 248);
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowTemplate.MinimumHeight = 40;
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
        #endregion

        #region OrderDatagridView

        #region SortColumnAsce()
        public static void SortColumnAsce(DataGridView dtgGrid, int colunaIndex)
        {
            dtgGrid.Sort(dtgGrid.Columns[colunaIndex], System.ComponentModel.ListSortDirection.Ascending);
        }
        #endregion

        #region SortColumnDesc()
        public static void SortColumnDesc(DataGridView dtgGrid, int colunaIndex)
        {
            dtgGrid.Sort(dtgGrid.Columns[colunaIndex], System.ComponentModel.ListSortDirection.Descending);
        }
        #endregion
        
        #endregion
    }
}
