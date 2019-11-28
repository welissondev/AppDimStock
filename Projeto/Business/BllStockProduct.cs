using System;
using DimStock.Model;
using System.Collections.Generic;
using DimStock.Report;
using DimStock.Auxiliary;
using System.Data;

namespace DimStock.Business
{
    public class BllStockProduct
    {
        #region Get e Set
        public int StockId { get; set; }
        public string Supplier { get; set; }
        public int StockQuantity { get; set; }
        public double StockValue { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string StockResume { get; set; }
        public string StockResult { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductSize { get; set; }
        public string ProductDescription { get; set; }
        public string ProductReference { get; set; }
        public double ProductCostPrice { get; set; }
        public string ProductPhotoName { get; set; }
        public List<BllStockProduct> ListOfRecords { get; set; }
        #endregion 

        #region Filter()
        public void Filter(string code, string size, string reference, 
        string description, int numberOfRecords = 20)
        {
            var stockProduct = new MdlStockProduct();

            ListOfRecords = stockProduct.Filter(code, size, reference, 
            description, numberOfRecords);
        }
        #endregion

        #region FetchData()
        public void FetchData(AxlDataPagination dataPagination)
        {
            var stockProduct = new MdlStockProduct(this);

            var dataTable = stockProduct.FetchData(dataPagination);

            PassDataTableToList(dataTable);
        }
        #endregion

        #region ListAll()
        public void ListAll()
        {
            var stockProduct = new MdlStockProduct(this);
            ListOfRecords = stockProduct.ListAll();

            SetResume();

            SetResult();
        }
        #endregion

        #region  PassDataTableToList()
        private void PassDataTableToList(DataTable dataTable)
        {
            ListOfRecords = new List<BllStockProduct>();

            foreach (DataRow row in dataTable.Rows)
            {
                var stockProduct = new BllStockProduct()
                {
                    StockId = Convert.ToInt32(row["TBEstoque.Id"]),
                    ProductId = Convert.ToInt32(row["TBProduto.Id"]),
                    Supplier = Convert.ToString(row["Fornecedor"]),
                    ProductCode = Convert.ToString(row["Codigo"]),
                    ProductReference = Convert.ToString(row["Referencia"]),
                    ProductSize = Convert.ToString(row["Tamanho"]),
                    ProductDescription = Convert.ToString(row["Descricao"]),
                    MinStock = Convert.ToInt32(row["EstoqueMin"]),
                    MaxStock = Convert.ToInt32(row["EstoqueMax"]),
                    StockQuantity = Convert.ToInt32(row["Quantidade"]),
                    StockValue = Convert.ToDouble(row["Valor"]),
                    ProductCostPrice = Convert.ToDouble(row["PrecoCusto"]),
                    ProductPhotoName = BllProdutoFoto.PegarCaminho() 
                    + Convert.ToString(row["FotoNome"]),
                };

                ListOfRecords.Add(stockProduct);
            }

            SetResume();

            SetResult();
        }
        #endregion

        #region SetResume()
        private void SetResume()
        {
            var ls = ListOfRecords;

            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].StockQuantity > 0 && ls[i].StockQuantity >=
                    ls[i].MinStock && ls[i].StockQuantity <= ls[i].MaxStock)
                    ls[i].StockResume = "OK";

                if (ls[i].StockQuantity > ls[i].MaxStock)
                    ls[i].StockResume = "Alto";

                if (ls[i].StockQuantity < ls[i].MinStock)
                    ls[i].StockResume = "Baixo";

                if (ls[i].StockQuantity == 0 & ls[i].MinStock == 0 && ls[i].MaxStock == 0)
                    ls[i].StockResume = "???";
            }
        }
        #endregion

        #region SetResult()
        public void SetResult()
        {
            var ls = ListOfRecords;

            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].StockQuantity < ls[i].MinStock)
                    ls[i].StockResult = " + " + Convert.ToString(ls[i].MinStock - ls[i].StockQuantity);

                if (ls[i].StockQuantity > ls[i].MaxStock)
                    ls[i].StockResult = " - " + Convert.ToString(ls[i].StockQuantity - ls[i].MaxStock);
                
                if(ls[i].StockQuantity > 0 && ls[i].StockQuantity >= ls[i].MinStock && 
                    ls[i].StockQuantity <= ls[i].MaxStock)
                    ls[i].StockResult = "OK";

                if(ls[i].StockQuantity == 0 && ls[i].MinStock == 0 && ls[i].MaxStock == 0)
                    ls[i].StockResult = "???";
            }
        }
        #endregion

        #region ViewData()
        public void ViewData(int id)
        {
            var stockProduct = new MdlStockProduct(this);
            stockProduct.ViewData(id);
        }
        #endregion

        #region GenerateReport()
        public void GenerateReport()
        {
            var reportStockProduct = new ReportStockProduct();
            reportStockProduct.Generate(ListOfRecords);
        }
        #endregion
    }
}
