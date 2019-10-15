using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysEstoque.Auxiliary
{
    public class AxlListEstoqueItem : DataGridView
    {

        private bool listTypeEstoque;
        public bool ListTypeEstoque
        {
            get { return listTypeEstoque; }
            set { listTypeEstoque = value; listTypeItem = false; }
        }

        private bool listTypeItem;
        public bool ListTypeItem
        {
            get { return listTypeItem; }
            set { listTypeItem = value; listTypeEstoque = false; }
        }
    }
}
