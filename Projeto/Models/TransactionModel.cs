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
    }

    public partial class TransactionModel
    {
        public TransactionModel(bool beginAutomaticTransaction = true)
        {
            dataBase = new ConnectionModel();

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
            dataBase.BeginTransaction(dataBase.Open());
        }
        public void ExecuteCommit()
        {
            dataBase.TransactionExecuteCommit();
        }

        public int ExecuteCommand(string sql)
        {
            return dataBase.TransactionExecuteCommand(sql);
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
