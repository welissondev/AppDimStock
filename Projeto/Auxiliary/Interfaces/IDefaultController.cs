namespace DimStock.Auxiliary.Interfaces
{
    public interface IDefaultController
    {
        bool Register();
        bool Edit(int id);
        bool Delete(int id);
        void FetchData();
        void ListAll();
        void ViewData(int id);
    }
}
