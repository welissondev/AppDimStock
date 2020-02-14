using System.Collections.Generic;

namespace DimStock.Interfaces
{
    public interface IReport<T>
    {
        void GenerateReport(List<T> list);
    }
}
