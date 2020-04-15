using System;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo que manipula o transacionamento da conexão
    /// </summary>
    public partial class TransactionModel : IDisposable
    {
        private bool disposed = false;
        private ConnectionModel dataBase;

        public string SqlQuery { get; set; }
        public string SqlScala { get; set; }
    }

    public partial class TransactionModel
    {
        public TransactionModel(ConnectionModel connection, bool beginAutomaticTransaction = true)
        {
            dataBase = connection;

            if (beginAutomaticTransaction == true)
                Begin();
        }

        public void AddParameter(string name, object value)
        {
            dataBase.AddParameter(name, value);
        }
        public void ClearParameter()
        {
            dataBase.ClearParameter();
        }

        public void Begin()
        {
            dataBase.Transaction = dataBase.Open().BeginTransaction();
        }
        public void Commit()
        {
            dataBase.Transaction.Commit();
        }

        public int ExecuteCommand(string sql)
        {
            return dataBase.ExecuteTransaction(sql);
        }
        public int ExecuteScalar(string sql)
        {
            return Convert.ToInt32(dataBase.ExecuteScalar(sql));
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                dataBase.Dispose();
            }

            disposed = true;
        }
    }
}
