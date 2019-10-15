using System.Drawing;
using System.Windows.Forms;

namespace SysEstoque.Auxiliary
{
    public static class AxlDataGridViewLealt
    {

        /// <summary>
        /// DataGridView lealt azul com grade
        /// </summary>
        /// <param name="datagrid"></param>
        public static void DefaultLayoutModifiedPattern(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(53, 63, 77);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 63, 77);
            datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(252, 252, 252);
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.0F, FontStyle.Regular);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 40;
            datagrid.RowTemplate.MinimumHeight = 40;
            datagrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(41, 41, 41);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(41, 41, 41);

            datagrid.AllowUserToAddRows = false;
            datagrid.BorderStyle = BorderStyle.Fixed3D;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;

            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ColumnHeadersVisible = true;
            datagrid.AllowUserToResizeColumns = false;
            datagrid.AutoGenerateColumns = false;
        }


        /// <summary>
        /// DataGridView lealt azul com grade
        /// </summary>
        /// <param name="datagrid"></param>
        public static void DefaultLayoutDarkblue(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.FromArgb(223, 225, 226);
            datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);  
            //datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 40;
            //datagrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 9.0F);
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

        /// <summary>
        /// DataGridView lealt verde Claro com grade
        /// </summary>
        /// <param name="datagrid"></param>
        public static void DefaultLayoutLightGreen(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.FromArgb(223, 225, 226);
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 189, 122);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(129, 189, 122);
            datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(252, 252, 252);
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 50;
            datagrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 9.0F);
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 248, 237);
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


        /// <summary>
        /// DataGridView lealt vermelho escuro com grade
        /// </summary>
        /// <param name="datagrid"></param>
        public static void DefaultLayoutDarkRed(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.FromArgb(223, 225, 226);
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(182, 56, 56);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(182, 56, 56);
            datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(252, 252, 252);
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 50;
            datagrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 9.0F);
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 241, 240);
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


        /// <summary>
        /// DataGridView lealt vermelho escuro com grade
        /// </summary>
        /// <param name="datagrid"></param>
        public static void DefaultLayoutDarkYellow(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.FromArgb(223, 225, 226);
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(216, 179, 10);
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(216, 179, 10);
            datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(252, 252, 252);
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            datagrid.ColumnHeadersHeight = 50;
            datagrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 8.0F);
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 247, 221);
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

        /// <summary>
        /// DataGridView lealt vermelho escuro com grade
        /// </summary>
        /// <param name="datagrid"></param>
        public static void DefaultLayoutClean(DataGridView datagrid)
        {
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.GridColor = Color.FromArgb(253, 247, 221);
            datagrid.BackgroundColor = Color.White;
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 247, 221);
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(86, 86, 86);
            //datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            //datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            datagrid.ColumnHeadersHeight = 35;
            //datagrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 8.0F);
            datagrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(86, 86, 86);
            datagrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(206, 237, 248);
            datagrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(86, 86, 86);
            //datagrid.RowTemplate.MinimumHeight = 50;
            datagrid.AllowUserToAddRows = false;
            //datagrid.BorderStyle = BorderStyle.None;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Custom;

            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ColumnHeadersVisible = true;
            datagrid.AllowUserToResizeColumns = false;
            datagrid.AutoGenerateColumns = false;

        }


        #region Ordenar datagridview
        public static void SortcolumnAsce(DataGridView dtgGrid, int colunaIndex)
        {
            dtgGrid.Sort(dtgGrid.Columns[colunaIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        public static void SortcolumnDesc(DataGridView dtgGrid, int colunaIndex)
        {
            dtgGrid.Sort(dtgGrid.Columns[colunaIndex], System.ComponentModel.ListSortDirection.Descending);
        }
        #endregion
    }
}
