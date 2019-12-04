using System;
using DimStock.Auxiliary;
using DimStock.Business;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

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

        #region Add()
        public bool Add()
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

        #region UpdateSituation()
        public bool UpdateSituation(MdlConnection connection, int activityId)
        {
            var commandSQL = @"UPDATE TBEstoqueAtividade Set Situacao = 'Finalizada' Where Id = " + activityId;
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
                    DataFromAffectedRecord = GetDataFromAffectedRecord(activityId)
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
        public List<BllStockActivity> ListAll(int numberOfRecords = 100)
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = @"SELECT TOP " + numberOfRecords + " * From TBEstoqueAtividade";

                var listStockActivity = new List<BllStockActivity>();

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

                        listStockActivity.Add(stockActivity);
                    }
                }

                return listStockActivity;
            }
        }
        #endregion

        #region FetchData()
        public List<BllStockActivity> FetchData(string activityNumber, string type, string operation, 
        string startDate, string finalDate, int numberOfRecords = 100)
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = @"SELECT TOP " + numberOfRecords +
                @" * From TBEstoqueAtividade WHERE Data >= @DataInicio AND Data <= @DataFinal";

                var criterion = "";

                if (activityNumber != "")
                    criterion += " And Id LIKE @Id";

                if (type != "")
                    criterion += " And Tipo LIKE @Tipo";

                if (operation != "")
                    criterion += " And Situacao LIKE @Situacao";

                commandSQL += criterion;

                var e = connection.Command.Parameters;
                e.AddWithValue("@DataInicio", string.Format("{0}", startDate));
                e.AddWithValue("@DataFinal", string.Format("{0}", finalDate));

                if (activityNumber != "")
                    e.AddWithValue("@Id", string.Format("{0}", activityNumber));

                if (type != "")
                    e.AddWithValue("@Tipo", string.Format("{0}", type));

                if (operation != "")
                    e.AddWithValue("@Situacao", string.Format("{0}", operation));

                var listStockActivity = new List<BllStockActivity>();

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

                        listStockActivity.Add(stockActivity);
                    }
                }

                return listStockActivity;
            }
        }
        #endregion

        #region GetActivityDetails()
        public void GetActivityDetails(int id)
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

        #region GetDataFromAffectedRecords()
        public string GetDataFromAffectedRecord(int id)
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
    }
}
