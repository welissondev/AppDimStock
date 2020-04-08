using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimStock.AuxilyTools.Controls
{
    public class CustomComboBoxView : TextBox
    {
        public CustomDataGridViewTwo ListItems;

        public CustomComboBoxView()
        {
            AddListingBox();
        }

        public void AddListingBox()
        {
            ListItems = new CustomDataGridViewTwo();
            Controls.Add(ListItems);

            ListItems.Location = Location;
            ListItems.Top = Top +20;
            ListItems.Width = Width;
           
            ListItems.BringToFront();
        }
    }
}
