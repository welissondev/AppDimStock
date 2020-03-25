namespace DimStock.Views
{
    public interface IProductAddView
    {
        int Id { get; set; }
        string InternalCode { get; set; }
        string Description { get; set; }
        double CostPrice { get; set; }
        double SalePrice { get; set; }
        string BarCode { get; set; }
        int CategoryId { get; set; }
        string CategoryDescription { get; set; }
    }
}
