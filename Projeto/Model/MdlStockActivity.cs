using System;
using DimStock.Auxiliary;
using DimStock.Business;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Data;

namespace DimStock.Model
{
    public class MdlStockActivity
    {
        #region Properties
        private readonly BllStockActivity stockActivity;
        #endregion

        #region Constructs
        public MdlStockActivity() { }

        public MdlStockActivity(BllStockActivity stockActivity)
        {
            this.stockActivity = stockActivity;
        }
        #endregion

        #region Register()
        public bool Register()
        {
            bool addState = false;

            using (var connection = new MdlConnection())
            {
                var commandSQL = @"INSERT INTO TBEstoqueAtividade(Tipo, Data, Hora, Situacao)
                VALUES(@Tipo, @Data, @Hora, @Situacao)";

                connection.AddParameter("@Tipo", OleDbType.VarChar, stockActivity.Type);
                connection.AddParameter("@Data", OleDbType.Date, stockActivity.Date);
                connection.AddParameter("@Hora", OleDbType.VarChar, stockActivity.Hour);
                connection.AddParameter("@Situacao", OleDbType.VarChar, stockActivity.Situation);

                if (connection.ExecuteNonQuery(commandSQL) > 0)
                {
                    stockActivity.Id = Convert.ToInt32(connection.ExecuteScalar(@"SELECT MAX(Id) FROM TBEstoqueAtividade"));

                    if (stockActivity.Id > 0)
                    {
                        addState = true;
                    }

                }

                return addState;
            }
        }
        #endregion

        #region AddDestination()
        public bool AddDestination(int id)
        {
            bool addState = false;

            if (stockActivity.Destination != "")
            {
                using (var connection = new MdlConnection())
                {
                    var commandSQL = @"UPDATE TBEstoqueAtividade SET Destino = @Destino WHERE Id =" + id;

                    connection.AddParameter("@Destino", OleDbType.VarChar, stockActivity.Destination);

                    addState = connection.ExecuteNonQuery(commandSQL) > 0;
                }
            }

            return addState;
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            bool deleteState = false;

            using (var connection = new MdlConnection())
            {
                var commandSQL = @"DELETE FROM TBEstoqueAtividade WHERE Id = " + id;

                if (connection.ExecuteNonQuery(commandSQL) > 0)
                {
                    BllNotification.Message = "Atividade deletada com sucesso!";
                    deleteState = true;
                }
                else
                {
                    BllNotification.Message = "Essa atividade já foi deletada, " +
                    "atualize a lista de dados!";
                }
            }

            return deleteState;
        }
        #endregion 

        #region ChangeSituation()
        public bool ChangeSituation(MdlConnection connection, int id)
        {
            var commandSQL = @"UPDATE TBEstoqueAtividade Set Situacao = 'Finalizada' Where Id = " + id;
            var transactionState = false;

            if (connection.ExecuteTransaction(commandSQL) > 0)
            {
                var historic = new BllUserHistoric()
                {
                    Login = AxlLogin.Login,
                    OperationType = "Confirmou",
                    Module = "Atividade",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    DataFromAffectedRecord = GetAffectedFields(id)
                };

                if (historic.Register() == true)
                {
                    transactionState = true;
                }
            }

            return transactionState;
        }
        #endregion

        #region ListAll()
        public void ListAll()
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = @"SELECT * From TBEstoqueAtividade";

                var stockActivityList = new List<BllStockActivity>();

                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        var stockActivity = new BllStockActivity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Type = dr["Tipo"].ToString(),
                            Date = Convert.ToDateTime(dr["Data"]),
                            Hour = dr["Hora"].ToString(),
                            Situation = dr["Situacao"].ToString(),
                        };

                        stockActivityList.Add(stockActivity);
                    }

                    stockActivity.ListOfRecords = stockActivityList;
                }
            }
        }
        #endregion

        #region FetchData()
        public void FetchData()
        {
            using (var connection = new MdlConnection())
            {
                #region Variáveis
                var commandSQL = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;
                var sqlCount = string.Empty;
                #endregion 

                #region Query Padrão

                commandSQL = @"SELECT * From TBEstoqueAtividade WHERE Id > 0 ";

                sqlCount = @"SELECT COUNT(*) FROM TBEstoqueAtividade WHERE Id > 0 ";

                #endregion

                #region Critério + DataInicial e DataFinal

                if (stockActivity.QueryByStartDate != string.Empty
                 && stockActivity.QueryByFinalDate != string.Empty)
                {
                    criterion += @"AND Data >= @StartDate AND Data <= @FinalDate ";

                    sqlCount += @"AND Data >= @StartDate AND Data <= @FinalDate ";

                    parameter.AddWithValue("@StartDate", string.Format("{0}",
                    stockActivity.QueryByStartDate));

                    parameter.AddWithValue("@FinalDate", string.Format("{0}",
                    stockActivity.QueryByFinalDate));
                }

                #endregion

                #region Critério + Tipo
                if (stockActivity.QueryByType != string.Empty)
                {
                    criterion += @"AND Tipo LIKE @Type ";

                    sqlCount += @"AND Tipo LIKE @Type ";

                    parameter.AddWithValue("@Type", string.Format("{0}",
                    stockActivity.QueryByType));
                }
                #endregion

                #region Critério + Situação
                if (stockActivity.QueryBySituation != string.Empty)
                {
                    criterion += @"AND Situacao LIKE @Situation ";

                    sqlCount += @"AND Situacao LIKE @Situation ";

                    parameter.AddWithValue("@Situation", string.Format("{0}",
                    stockActivity.QueryBySituation));

                }
                #endregion

                #region Critério + Número da atividade
                if (stockActivity.QueryByActivityNumber != string.Empty)
                {
                    criterion += @"AND Id LIKE @ActvityNumber ";

                    sqlCount += @"AND Id LIKE @ActivityNumber ";

                    parameter.AddWithValue("@ActvityNumber", string.Format("{0}",
                    stockActivity.QueryByActivityNumber));
                }
                #endregion

                #region ComandoSQL + Critério
                commandSQL += criterion;
                #endregion

                #region RecordCount

                stockActivity.DataPagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                #endregion 

                #region Preenche DataTable
                var dataTable = connection.QueryWithDataTable(commandSQL,
                stockActivity.DataPagination.OffSetValue,
                stockActivity.DataPagination.PageSize);
                #endregion 

                PassDataTableToList(dataTable);
            }
        }
        #endregion

        #region GetDetails()
        public void GetDetails(int id)
        {
            var commandSQL = @"SELECT * FROM TBEstoqueAtividade WHERE Id = " + id;

            using (var connection = new MdlConnection())
            {
                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        stockActivity.Id = Convert.ToInt32(dr["Id"]);
                        stockActivity.Type = Convert.ToString(dr["Tipo"]);
                        stockActivity.Date = Convert.ToDateTime(dr["Data"]);
                        stockActivity.Hour = Convert.ToString(dr["Hora"]);
                        stockActivity.Situation = Convert.ToString(dr["Situacao"]);
                        stockActivity.Destination = Convert.ToString(dr["Destino"]);
                    }
                }
            }
        }
        #endregion

        #region GetAffectedFields()
        public string GetAffectedFields(int id)
        {
            using (var connection = new MdlConnection())
            {

                var commandSQL = @"SELECT * From TBEstoqueAtividade Where Id = " + id;

                var affectedFieldList = new List<string>();

                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        affectedFieldList.Add("Id:" + dr["Id"].ToString());
                        affectedFieldList.Add("Tipo:" + dr["Tipo"].ToString());
                        affectedFieldList.Add("Data:" + Convert.ToDateTime(dr["Data"]).ToString("dd-MM-yyyy"));
                        affectedFieldList.Add("Hora:" + dr["Hora"].ToString());
                        affectedFieldList.Add("Situacao:" + dr["Situacao"].ToString());
                    }
                }

                return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
            }
        }
        #endregion

        #region PassDataTableToList()
        private void PassDataTableToList(DataTable dataTable)
        {
            var activityStockList = new List<BllStockActivity>();

            foreach (DataRow row in dataTable.Rows)
            {
                var stockActivity = new BllStockActivity()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Type = Convert.ToString(row["Tipo"]),
                    Date = Convert.ToDateTime(row["Data"]),
                    Hour = Convert.ToString(row["Hora"]),
                    Situation = Convert.ToString(row["Situacao"])
                };

                activityStockList.Add(stockActivity);
            }

            stockActivity.ListOfRecords = activityStockList;
        }
        #endregion
    }
}
