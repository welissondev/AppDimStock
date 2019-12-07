using System;
using DimStock.Auxiliary;
using DimStock.Model;
using DimStock.Report;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class BllProduct 
    {
        #region Constructors

        public BllProduct(){ }

        public BllProduct(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        #endregion

        #region BussinesProperties
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

        #region QueryProperties

        public string QueryByCode{get;set;}
        public string QueryBySize{get;set;}
        public string QueryByReference{get;set;}
        public string QueryByDescription{get;set;}
        public AxlDataPagination DataPagination { get; set; }

        #endregion

        #region Methods

        #region Register()
        public bool Register()
        {
            var product = new MdlProduct(this);

            if (product.Register() == true)
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

        #region Edit()
        public bool Edit(int id)
        {
            var product = new MdlProduct(this);

            if (product.Edit(id) == true)
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
        public void ListAll()
        {
            var product = new MdlProduct(this);
            product.ListAll();
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
        public void FetchData()
        {
            var product = new MdlProduct(this);
            product.FetchData();
        }
        #endregion

        #region GenerateReport()

        public void GenerateReport(List<BllProduct> listOfRecords)
        {
            var reportProduct = new ReportProduct();
            reportProduct.GenerateReport(listOfRecords);
        }

        #endregion 

        #endregion
    }
}
