using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using DimStock.Auxiliarys;

namespace DimStock.Business
{
    public class ProductCategory
    {
        public ProductCategory() { }

        public ProductCategory(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public List<ProductCategory> ListOfRecords { get; set; }
        public AxlDataPagination DataPagination { get; set; }

        public bool Register()
        {
            var registerState = false;
            var sqlCommand = string.Empty;

            using (var connection = new Connection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    sqlCommand = @"INSERT INTO ProductCategory
                    (Description)VALUES(@Description)";

                    connection.AddParameter("@Description", 
                    OleDbType.VarChar, Description);

                    registerState = 
                    connection.ExecuteTransaction(
                    sqlCommand) > 0;

                    //Pegar id do último registro inserido
                    Id = Convert.ToInt32(connection.ExecuteScalar(
                    "SELECT MAX(Id) From ProductCategory"));

                    //Registrar histórico do usuário
                    var userHistory = new UserHistory(connection)
                    {
                        UserId = AxlLogin.Id,
                        OperationType = "Cadastrou",
                        OperationModule = "Produto Categoria",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = GetAffectedFields(Id, connection)
                    };

                    registerState = userHistory.Register();

                    //Finalizar transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Categoria " +
                    "cadastrada com sucesso!";
                }

                return registerState;
            }
        }

        public bool Modify(int id)
        {
            return false;
        }

        public bool Delete(int id)
        {
            return false;
        }

        public void SearchData()
        {

        }

        public string GetAffectedFields(int id, Connection connection)
        {
            var affectedFieldList = new List<string>();

            var commandSQL = @"SELECT * From ProductCategory Where Id = @Id";
            connection.AddParameter("@Id", OleDbType.Integer, id);

            using (var dataReader = connection.QueryWithDataReader(commandSQL))
            {
                while (dataReader.Read())
                {
                    affectedFieldList.Add("Id:" + dataReader["Id"].ToString());
                    affectedFieldList.Add("Descrição:" + dataReader["Description"].ToString());
                }
            }

            return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
        }
    }
}
