using System.Collections.Generic;

namespace DimStock.Interfaces
{
    public interface IDataFetch<T>
    {
        List<T> List { get; set; }

        void FetchData();
    }
}
