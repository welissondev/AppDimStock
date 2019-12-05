using System.Collections.Generic;

namespace DimStock.Auxiliary.Interfaces
{
    public interface IReportController<T>
    {
        void GenerateReport(List<T> listOfRecords);
    }
}
