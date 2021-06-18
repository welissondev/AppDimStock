using System;

namespace DimStock.Views
{
    public interface IStockMoveView
    {
        int Id { get; set; }
        string IndentificationNumber { get; set; }
        DateTime StartDate { get; set; }
        DateTime StartHour { get; set; }
        DateTime FinishDate { get; set; }
        DateTime FinishHour { get; set; }
        string Situation { get; set; }
        int TypeId { get; set; }
        string TypeDescription { get; set; }
    }
}



