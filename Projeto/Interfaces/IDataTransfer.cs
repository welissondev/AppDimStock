namespace DimStock.Interfaces
{
    interface IDataTransfer<T>
    {
        void PassToList(T type);
    }
}
