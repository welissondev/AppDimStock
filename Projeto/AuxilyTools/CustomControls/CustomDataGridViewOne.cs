using System.Windows.Forms;

namespace DimStock.AuxilyTools.CustomControls
{
    public class CustomDataGridViewOne : DataGridView
    {

        private bool listIsStock;
        public bool ListIsStock
        {
            get { return listIsStock; }
            set { listIsStock = value; listIsItem = false; }
        }

        private bool listIsItem;
        public bool ListIsItem
        {
            get { return listIsItem; }
            set { listIsItem = value; listIsStock = false; }
        }
    }
}
