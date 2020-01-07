using System;
using DimStock.Auxiliary;
using DimStock.Model;
using DimStock.Report;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class ProductController
    {
        #region Constructors

        public ProductController() { }

        public ProductController(DataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        #endregion

        #region BussinesProperties
        public int Id { get; set; }
        public int Code { get; set; }
        public int Size { get; set; }
        public int Reference { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string BarCode { get; set; }
        public string PhotoName { get; set; }
        public List<ProductController> ListOfRecords { get; set; }
        #endregion 

        #region SearchProperties

        public string SearchByCode { get; set; }
        public string SearchBySize { get; set; }
        public string SearchByReference { get; set; }
        public string SearchByDescription { get; set; }
        public DataPagination DataPagination { get; set; }

        #endregion

        #region Methods

        public bool Register()
        {
            var product = new ProductModel(this);
            var registerState = false;

            if (product.Insert() == true)
            {
                var historic = new UserHistoryController()
                {
                    Login = LoginAssistant.Login,
                    OperationType = "Cadastrou",
                    OperationModule = "Produto",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    AffectedFields = product.GetAffectedFields(Id)
                };

                if (historic.Register() == true)
                    registerState = true;

            }

            return registerState;
        }

        public bool Edit(int id)
        {
            var product = new ProductModel(this);
            var editState = false;

            if (product.Update(id) == true)
            {
                var historic = new UserHistoryController()
                {
                    Login = LoginAssistant.Login,
                    OperationType = "Editou",
                    OperationModule = "Produto",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    AffectedFields = product.GetAffectedFields(id)
                };

                if (historic.Register() == true)
                    editState = true;
            }

            return editState;
        }

        public bool Exclude(int id)
        {
            var product = new ProductModel(this);
            var deleteState = false;

            var affecetdFileds = product.GetAffectedFields(id);

            if (product.Delete(id) == true)
            {
                var historic = new UserHistoryController()
                {
                    Login = LoginAssistant.Login,
                    OperationType = "Deletou",
                    OperationModule = "Produto",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    AffectedFields = affecetdFileds
                };

                if (historic.Register() == true)
                    deleteState = true;
            }

            return deleteState;
        }

        public void ListData()
        {
            var product = new ProductModel(this);
            product.ListData();
        }

        public void SearchData()
        {
            var product = new ProductModel(this);
            product.DataQuery();
        }

        public void ViewDetails(int id)
        {
            var product = new ProductModel(this);
            product.ViewDetails(id);
        }

        public void GenerateReport(List<ProductController> listOfRecords)
        {
            var product = new ReportProduct();
            product.GenerateReport(listOfRecords);
        }

        #endregion
    }
}
