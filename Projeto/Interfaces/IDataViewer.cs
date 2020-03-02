using System.Collections.Generic;

namespace DimStock.Interfaces
{
    interface IDataViewer<T>
    {
        void GetDetail(int id);
    }
}
