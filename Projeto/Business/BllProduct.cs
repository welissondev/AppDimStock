using DimStock.Auxiliary;
using DimStock.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace DimStock.Business
{
    public class BllProduct
    {
        #region Get e Set
        public int Id { get; set; }
        public string Code { get; set; }
        public string Size { get; set; }
        public string Reference { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string BarCode { get; set; }
        public string PhotoName { get; set; }
        public string FolderDirectoryOfPhothos { get => BllProductPhotho.GetPeth(); }
        public List<BllProduct> ListOfRecords { get; set; }
        #endregion 

        #region Register()
        public bool Register()
        {
            var product = new MdlProduct(this);

            if (product.Rigister() == true)
            {
                var historic = new BllUserHistoric()
                {
                    Login = AxlLogin.Login,
                    OperationType = "Cadastrou",
                    Module = "Produto",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    DataFromAffectedRecord = product.GetDataFromAffectedRecord(Id)
                };

                return historic.Register();
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Update()
        public bool Update(int id)
        {
            var product = new MdlProduct(this);

            if (product.Update(id) == true)
            {
                var historic = new BllUserHistoric()
                {
                    Login = AxlLogin.Login,
                    OperationType = "Editou",
                    Module = "Produto",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    DataFromAffectedRecord = product.GetDataFromAffectedRecord(id)
                };

                return historic.Register();
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            var product = new MdlProduct(this);

            var registryDataDeletedByUser = product.GetDataFromAffectedRecord(id);

            if (product.Delete(id) == true)
            {
                var historic = new BllUserHistoric()
                {
                    Login = AxlLogin.Login,
                    OperationType = "Deletou",
                    Module = "Produto",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    DataFromAffectedRecord = registryDataDeletedByUser
                };

                return historic.Register();
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ListAll()
        public void ListAll(int numeroDeRegistros = 100)
        {
            var product = new MdlProduct();
            ListOfRecords = product.ListAll(numeroDeRegistros);
        }
        #endregion

        #region ViewData()
        public void ViewData(int id)
        {
            var product = new MdlProduct(this);
            product.ViewData(id);
        }
        #endregion

        #region FetchData()
        public void FetchData(AxlDataPagination dataPagination)
        {
            var product = new MdlProduct(this);

            var dataTable = product.FetchData(dataPagination);

            PassDataTableForList(dataTable);
        }
        #endregion

        #region PassDataTableForList()
        public void PassDataTableForList(DataTable datatable)
        {
            ListOfRecords = new List<BllProduct>();

            foreach(DataRow row in datatable.Rows)
            {
                var product = new BllProduct()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Code = Convert.ToString(row["Codigo"]),
                    Size =  Convert.ToString(row["Tamanho"]),
                    Reference = Convert.ToString(row["Referencia"]),
                    Supplier = Convert.ToString(row["Fornecedor"]),
                    Description = Convert.ToString(row["Descricao"]),
                    CostPrice = Convert.ToDouble(row["PrecoCusto"]),
                    SalePrice = Convert.ToDouble(row["PrecoVenda"]),
                    PhotoName = Convert.ToString(row["FotoNome"])
                };

                ListOfRecords.Add(product);
            }
        }
        #endregion
    }
}
