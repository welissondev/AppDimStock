using System.Collections.Generic;

namespace DimStock.Interfaces
{
    interface IDataList<T>
    {
        List<T> List { get; set; }

        void ListData();
    }
}
