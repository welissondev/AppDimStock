using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de movimentação do estoque
    /// </summary>
    public partial class MovementModel
    {
        private TransactionModel transaction;

        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public string Code { get; set; }
        public string Situation { get; set; }
        public DestinationModel Destination { get; set; }
    }

    public partial class MovementModel
    {
        public MovementModel()
        {
            Destination = new DestinationModel();
        }

        public bool StartOperation()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (transaction = new TransactionModel())
            {
                sql = @"INSERT INTO Movement([Type])VALUES(@Type)";

                ParameterModel.Clear();
                ParameterModel.Add("@Type", Type);

                if (transaction.ExecuteNonQuery(sql) > 0)
                {
                    if (SetOperationCode() == true)
                    {
                        transaction.Commit();
                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }
        public bool FinishOperation()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (transaction = new TransactionModel())
            {
                if (InsertPostings() == true)
                {
                    sql = @"UPDATE Movement Set Situation = 
                    'Finalizada' WHERE Id = @Id";

                    ParameterModel.Clear();
                    ParameterModel.Add("@Id", Id);

                    if (transaction.ExecuteNonQuery(sql) > 0)
                    {
                        transaction.Commit();
                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool SetOperationCode()
        {
            var seed = GetLastId();
            Code = new SingleCodeGenerator(seed).GetCode();

            var sql = @"UPDATE Movement SET Code = @Code WHERE Id = @Id";

            ParameterModel.Clear();
            ParameterModel.Add("@Code", Code);
            ParameterModel.Add("@Id", Id);

            return transaction.ExecuteNonQuery(sql) > 0;
        }

        public bool SetDestinationId()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"UPDATE Movement SET DestinationId = @DestinationId WHERE Id = @Id";

                ParameterModel.Clear();
                ParameterModel.Add("@DestinationId", Destination.Id);
                ParameterModel.Add("@Id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool InsertPostings()
        {
            var actionResult = false;
            var postedItems = GetPostedItems();

            switch (Type)
            {
                case "Entry":

                    if (new StockModel(transaction).InsertPostingOfEntries(postedItems) == true)
                    {
                        MessageNotifier.Set("Entradas lançadas " +
                        "com sucesso no estoque!", "Sucesso");

                        actionResult = true;
                    }

                    break;

                case "OutPut":

                    if (new StockModel(transaction).InsertPostingOfOutPuts(postedItems) == true)
                    {
                        MessageNotifier.Set("Saídas lançadas " +
                        "com sucesso no estoque!", "Sucesso");

                        actionResult = true;
                    }

                    break;
            }

            return actionResult;
        }
        public bool CancelPostings()
        {
            var actionResult = false;
            var postedItems = GetPostedItems();

            switch (Type)
            {
                case "Entry":

                    if (new StockModel(transaction).CancelPostingOfEntries(postedItems) == true)
                    {
                        MessageNotifier.Set("Entradas canceladas " +
                        "com sucesso do estoque!", "Sucesso");

                        actionResult = true;
                    }

                    break;

                case "OutPut":

                    if (new StockModel(transaction).CancelPostingOfOutPuts(postedItems) == true)
                    {
                        MessageNotifier.Set("Saídas canceladas " +
                        "com sucesso do estoque!", "Sucesso");

                        actionResult = true;
                    }

                    break;
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (transaction = new TransactionModel())
            {
                if (CancelPostings() == true)
                {
                    sql = @"DELETE FROM Movement WHERE Id = @Id";

                    ParameterModel.Clear();
                    ParameterModel.Add("Id", Id);

                    if (transaction.ExecuteNonQuery(sql) > 0)
                    {
                        MessageNotifier.Set("Movimentação excluida " +
                        "com sucesso!", "Sucesso");

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool GetDetail()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Movement.*, Destination.* FROM Movement LEFT JOIN 
                Destination ON Movement.DestinationId = Destination.Id WHERE 
                Movement.Id = @Id";

                ParameterModel.Clear();
                ParameterModel.Add("Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.FieldCount > 0)
                    {
                        while (reader.Read())
                        {
                            Id = int.Parse(reader["Movement.Id"].ToString());
                            Type = reader["[Type]"].ToString();
                            Date = DateTime.Parse(reader["[Date]"].ToString());
                            Hour = DateTime.Parse(reader["[Hour]"].ToString());
                            Situation = reader["[Situation]"].ToString();
                            Code = reader["[Code]"].ToString();

                            if (reader["Destination.Id"] != DBNull.Value)
                                Destination.Id = int.Parse(reader["Destination.Id"].ToString());

                            Destination.Location = reader["Location"].ToString();
                        }

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public DataTable FetchData()
        {
            var link = string.Empty;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Movement.*, Destination.* FROM Movement
                LEFT JOIN Destination On Movement.DestinationId = 
                Destination.Id WHERE Movement.Id > 0 ";

                if (Type != string.Empty)
                {
                    link += @" AND [Type] LIKE @Type";
                    ParameterModel.Add("@Type", string.Format("{0}", Type));
                }

                if (Situation != string.Empty)
                {
                    link += @" AND Situation LIKE @Situation";
                    ParameterModel.Add("@Situation", string.Format("{0}", Situation));
                }

                if (Code != string.Empty)
                {
                    link += @" AND Movement.Code LIKE @Code ";
                    ParameterModel.Add("@Code", string.Format("{0}", Code));
                }

                sql += link + @" ORDER BY Movement.Id DESC";

                return dataBase.ExecuteDataAdapter(sql);
            }
        }

        public DataTable GetPostedItems()
        {
            return new MovementItemModel(this).ListItems();
        }

        public int GetLastId()
        {
            var sql = @"SELECT MAX(Id) FROM Movement";
            return transaction.ExecuteScalar(sql);
        }
    }
}